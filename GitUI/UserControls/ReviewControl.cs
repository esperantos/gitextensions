using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GitCommands;
using Review;

namespace GitUI.UserControls
{
    public partial class ReviewControl : GitModuleControl
    {
        private GitRevision currentRevision;

        public ReviewControl()
        {
            InitializeComponent();
            Translate();
            statusComboBox.Items.AddRange(Enum.GetValues(typeof (ReviewStatus)).Cast<object>().ToArray());
        }

        public RevisionGrid RevisionGrid { get; set; }

        public void SetRevision(GitRevision revision)
        {
            currentRevision = revision;
            try
            {
                var database = new ReviewDatabase();
                ReviewInfo reviewInfo = database.GetReviewInfo(revision.Guid);
                statusComboBox.SelectedItem = reviewInfo.Status;
                reviewCommentTextBox.Text = reviewInfo.Comment;
                UpdateChangeAuthor(reviewInfo);
            }
            catch (Exception exception)
            {
                reviewCommentTextBox.Text = exception.Message;
            }
        }

        private void UpdateChangeAuthor(ReviewInfo reviewInfo)
        {
            string authorText = string.IsNullOrWhiteSpace(reviewInfo.ChangeAuthor)
                ? "unknown" : reviewInfo.ChangeAuthor;
            var timeHints = new List<string>();
            if (reviewInfo.CreateTime != null)
                timeHints.Add(string.Format("created: {0:yyyy-MM-dd HH:mm}", reviewInfo.CreateTime.Value));
            if (reviewInfo.UpdateTime != null)
                timeHints.Add(string.Format("updated: {0:yyyy-MM-dd HH:mm}", reviewInfo.UpdateTime.Value));
            statusChangeAuthorLabel.Text = timeHints.Count == 0 
                ? authorText
                : string.Format("{0} ({1})", authorText, string.Join(", ", timeHints.ToArray()));
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            saveButton.Enabled = false;
            saveButton.Text = "Saving...";
            try
            {
                ReviewInfo reviewInfo = GetReviewInfo();
                new ReviewDatabase().Save(reviewInfo);
                UpdateChangeAuthor(reviewInfo);
                RevisionGrid.UpdateReviewInfo(reviewInfo);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            saveButton.Enabled = true;
            saveButton.Text = "Save";
        }

        private ReviewInfo GetReviewInfo()
        {
            return new ReviewInfo
            {
                CommitHash = currentRevision.Guid,
                Status = GetSelectedStatus(),
                Comment = reviewCommentTextBox.Text,
                ChangeAuthor = Module.GetEffectiveSetting("user.email").ToLower()
            };
        }

        private void reviewCommentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (GetSelectedStatus() == ReviewStatus.Unknown && char.IsLetterOrDigit(e.KeyChar))
                statusComboBox.SelectedItem = ReviewStatus.Declined;
        }

        private ReviewStatus GetSelectedStatus()
        {
            return (ReviewStatus) statusComboBox.SelectedItem;
        }

        private void reviewCommentTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == (char) Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                Save();
            }
        }

        private void reviewCommentTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == (char) Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}