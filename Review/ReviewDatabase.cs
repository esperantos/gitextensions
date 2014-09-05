using System;
using System.Collections.Generic;
using Npgsql;

namespace Review
{
    public class ReviewDatabase
    {
        private NpgsqlConnection OpenConnection()
        {
            var connection = new NpgsqlConnection(ReviewSettings.ConnectionString);
            connection.Open();
            return connection;
        }

        public ReviewScheme GetReviewScheme()
        {
            var scheme = new ReviewScheme();
            using (NpgsqlConnection connection = OpenConnection())
            {
                using (var command = new NpgsqlCommand("select author, reviewer from review_scheme", connection))
                {
                    using (NpgsqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            scheme.Add(dr.GetString(0), dr.GetString(1));
                        }
                    }
                }
            }
            return scheme;
        }

        public ReviewInfo GetReviewInfo(string commitHash)
        {
            using (NpgsqlConnection connection = OpenConnection())
            {
                return ExecuteGetReviewInfoCommands(commitHash, connection);
            }
        }

        private static ReviewInfo ExecuteGetReviewInfoCommands(string commitHash, NpgsqlConnection connection,
            NpgsqlTransaction transaction = null)
        {
            using (
                var command = new NpgsqlCommand(
                    "select commit_hash, status, comment, change_author, create_time, update_time from review where commit_hash = :commit_hash",
                    connection, transaction))
            {
                command.Parameters.Add(new NpgsqlParameter("commit_hash", commitHash));
                using (NpgsqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        return new ReviewInfo
                        {
                            CommitHash = dr.GetString(0),
                            Status = (ReviewStatus) dr.GetInt32(1),
                            Comment = dr.IsDBNull(2) ? null : dr.GetString(2),
                            ChangeAuthor = dr.IsDBNull(3) ? null : dr.GetString(3),
                            CreateTime = dr.IsDBNull(4) ? (DateTime?) null : dr.GetDateTime(4),
                            UpdateTime = dr.IsDBNull(5) ? (DateTime?) null : dr.GetDateTime(5),
                        };
                    }
                }
            }
            return new ReviewInfo {CommitHash = commitHash};
        }

        public IDictionary<string, ReviewInfo> GetReviews()
        {
            var reviewInfos = new Dictionary<string, ReviewInfo>();
            using (NpgsqlConnection connection = OpenConnection())
            {
                using (var command = new NpgsqlCommand("select commit_hash, status from review", connection))
                {
                    using (NpgsqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var reviewInfo = new ReviewInfo
                            {
                                CommitHash = dr.GetString(0),
                                Status = (ReviewStatus) dr.GetInt32(1),
                            };
                            reviewInfos.Add(reviewInfo.CommitHash, reviewInfo);
                        }
                    }
                }
            }
            return reviewInfos;
        }

        public void Save(ReviewInfo reviewInfo)
        {
            using (NpgsqlConnection connection = OpenConnection())
            {
                using (NpgsqlTransaction transaction = connection.BeginTransaction())
                {
                    ExecuteSaveCommands(reviewInfo, connection, transaction);
                    transaction.Commit();
                }
            }
        }

        private static void ExecuteSaveCommands(ReviewInfo reviewInfo, NpgsqlConnection connection,
            NpgsqlTransaction transaction)
        {
            string commitHash = reviewInfo.CommitHash;
            var status = (int) reviewInfo.Status;
            string comment = reviewInfo.Comment;
            string changeAuthor = reviewInfo.ChangeAuthor;

            long count;
            using (
                var countCommand =
                    new NpgsqlCommand("select count(*) from review where commit_hash = :commit_hash", connection,
                        transaction))
            {
                countCommand.Parameters.Add(new NpgsqlParameter("commit_hash", commitHash));
                count = (long) countCommand.ExecuteScalar();
            }
            if (count == 0)
            {
                using (
                    var countCommand =
                        new NpgsqlCommand(
                            "insert into review (commit_hash, status, comment, change_author) VALUES (:commit_hash, :status, :comment, :change_author)",
                            connection, transaction))
                {
                    countCommand.Parameters.Add(new NpgsqlParameter("commit_hash", commitHash));
                    countCommand.Parameters.Add(new NpgsqlParameter("status", status));
                    countCommand.Parameters.Add(new NpgsqlParameter("comment", comment));
                    countCommand.Parameters.Add(new NpgsqlParameter("change_author", changeAuthor));
                    countCommand.ExecuteNonQuery();
                }
            }
            else
            {
                using (
                    var countCommand =
                        new NpgsqlCommand(
                            "update review set status=:status, comment=:comment, change_author=:change_author where commit_hash=:commit_hash",
                            connection, transaction))
                {
                    countCommand.Parameters.Add(new NpgsqlParameter("commit_hash", commitHash));
                    countCommand.Parameters.Add(new NpgsqlParameter("status", status));
                    countCommand.Parameters.Add(new NpgsqlParameter("comment", comment));
                    countCommand.Parameters.Add(new NpgsqlParameter("change_author", changeAuthor));
                    countCommand.ExecuteNonQuery();
                }
            }
        }

        public void ChangeStatus(string hash, ReviewStatus reviewStatus, string user)
        {
            using (NpgsqlConnection connection = OpenConnection())
            {
                using (NpgsqlTransaction transaction = connection.BeginTransaction())
                {
                    ReviewInfo reviewInfo = ExecuteGetReviewInfoCommands(hash, connection, transaction);
                    reviewInfo.Status = reviewStatus;
                    reviewInfo.ChangeAuthor = user;
                    ExecuteSaveCommands(reviewInfo, connection, transaction);
                    transaction.Commit();
                }
            }
        }
    }
}