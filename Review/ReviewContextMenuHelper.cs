using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using GitCommands;

namespace Review
{
    public class ReviewContextMenuHelper
    {
        public static void SetReviewMenuItems(ToolStripMenuItem reviewMenuItem, string user, List<GitRevision> revisions,
            Bitmap acceptIcon, Bitmap bugIcon, Action<ReviewInfo> updateReviewInfoUi = null)
        {
            reviewMenuItem.DropDownItems.Clear();
            if (revisions.Count == 0) return;
            bool multipleCommits = revisions.Count > 1;
            var reviewAccepted = new ToolStripMenuItem
            {
                Name = "reviewAccepted",
                Image = acceptIcon,
                Text = multipleCommits ? "Accept commits" : "Accept commit"
            };
            reviewAccepted.Click += (sender, e) => AcceptRevisions(user, revisions, updateReviewInfoUi);
            reviewMenuItem.DropDownItems.Add(reviewAccepted);
            if (string.IsNullOrWhiteSpace(ReviewSettings.BugTraqUrl))
                return;
            List<string> bugIds = GetBugIds(revisions);
            if (bugIds.Count > 0)
                reviewMenuItem.DropDownItems.Add(new ToolStripSeparator());
            foreach (string bugId in bugIds)
            {
                string currentBugId = bugId;
                reviewMenuItem.DropDownItems.Add(
                    new ToolStripMenuItem(bugId, bugIcon,
                        (sender, args) => Process.Start(ReviewSettings.BugTraqUrl.Replace("%BUGID%", currentBugId))));
            }
        }

        public static void ClearReviewMenuItems(ToolStripMenuItem reviewMenuItem)
        {
            reviewMenuItem.DropDownItems.Clear();
            reviewMenuItem.DropDownItems.Add(new ToolStripSeparator());
        }

        private static void AcceptRevisions(string user, IEnumerable<GitRevision> revisions,
            Action<ReviewInfo> updateReviewInfoUi = null)
        {
            try
            {
                var db = new ReviewDatabase();
                foreach (GitRevision revision in revisions)
                {
                    db.ChangeStatus(revision.Guid, ReviewStatus.Accepted, user);
                    if (updateReviewInfoUi != null)
                        updateReviewInfoUi(new ReviewInfo {CommitHash = revision.Guid, Status = ReviewStatus.Accepted});
                }
            }
            catch (Exception)
            {
            }
        }

        private static List<string> GetBugIds(IEnumerable<GitRevision> revisions)
        {
            if (ReviewSettings.BugTraqRegex == null || ReviewSettings.BugTraqRegex.Length == 0)
                return new List<string>();
            var bugIds = new List<string>();
            List<Regex> regexes = ReviewSettings.BugTraqRegex.Select(bugtraqRegexStr => new Regex(bugtraqRegexStr)).ToList();
            foreach (GitRevision revision in revisions)
                foreach (Regex regex in regexes)
                    foreach (Match match in regex.Matches(revision.Message))
                        bugIds.Add(match.Value);
            return bugIds.Distinct().ToList();
        }
    }
}