using System;
using System.Linq;
using System.Windows.Forms;
using GitCommands;
using GitUIPluginInterfaces;
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
			statusComboBox.Items.AddRange(Enum.GetValues(typeof(ReviewStatus)).Cast<object>().ToArray());
		}

	    public void SetRevision(GitRevision revision)
		{
			currentRevision = revision;
			try
			{
				var database = new ReviewDatabase();
				var reviewInfo = database.GetReviewInfo(revision.Guid);
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
	        statusChangeAuthorLabel.Text = string.IsNullOrWhiteSpace(reviewInfo.ChangeAuthor)
	            ? "unknown"
	            : reviewInfo.ChangeAuthor;
	    }

	    private void saveButton_Click(object sender, EventArgs e)
		{
			saveButton.Enabled = false;
			saveButton.Text = "Saving...";
			try
			{
			    var reviewInfo = GetReviewInfo();
			    new ReviewDatabase().Save(reviewInfo);
                UpdateChangeAuthor(reviewInfo);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			saveButton.Enabled = true;
			saveButton.Text = "Save";

		}

		private ReviewInfo GetReviewInfo()
		{
			return new ReviewInfo
			{
				CommitHash=currentRevision.Guid,
				Status = (ReviewStatus) statusComboBox.SelectedItem,
				Comment = reviewCommentTextBox.Text,
                ChangeAuthor = Module.GetEffectiveSetting("user.email").ToLower()
			};

		}
	}
}
