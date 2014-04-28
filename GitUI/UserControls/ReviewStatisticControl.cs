using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GitCommands;
using Review;

namespace GitUI.UserControls
{
    public partial class ReviewStatisticControl : GitModuleControl
    {
        private const string careLabelPattern = "Commits of {0}";
        private readonly CheckBox[] filterCheckboxes;
        private readonly IList<GitRevision> revisions = new List<GitRevision>();
        private bool filtersUpdating;
        private ReviewScheme reviewScheme;
        private IDictionary<string, ReviewStatistic> reviewStatistics;
        private IDictionary<string, ReviewInfo> reviews;

        public ReviewStatisticControl()
        {
            InitializeComponent();
            Translate();
            filterCheckboxes = new[] {newCheckBox, correctedCheckBox, notReviewedCheckBox, declinedCheckBox, acceptedCheckBox, myAcceptedCheckBox};
            newCheckBox.Tag =
                new Func<IEnumerable<string>>(() => GetRevisionsForReview(GetSelectedDeveloper()).NotReviewed);
            correctedCheckBox.Tag =
                new Func<IEnumerable<string>>(() => GetRevisionsForReview(GetSelectedDeveloper()).Corrected);
            acceptedCheckBox.Tag =
                new Func<IEnumerable<string>>(() => GetRevisionsForReview(GetSelectedDeveloper()).Accepted);
            notReviewedCheckBox.Tag =
                new Func<IEnumerable<string>>(() => GetRevisionsForAttention(GetSelectedDeveloper()).NotReviewed);
            declinedCheckBox.Tag =
                new Func<IEnumerable<string>>(() => GetRevisionsForAttention(GetSelectedDeveloper()).Declined);
            myAcceptedCheckBox.Tag =
                new Func<IEnumerable<string>>(() => GetRevisionsForAttention(GetSelectedDeveloper()).Accepted);
            newCountLinkLabel.Tag = newCheckBox;
            correctedCountLinkLabel.Tag = correctedCheckBox;
            acceptedCountLinkLabel.Tag = acceptedCheckBox;
            notReviewedCountLinkLabel.Tag = notReviewedCheckBox;
            declinedCountLinkLabel.Tag = declinedCheckBox;
            myAcceptedCountLinkLabel.Tag = myAcceptedCheckBox;
        }

        public RevisionGrid RevisionGrid { get; set; }

		public void RefreshStatistic()
        {
            try
            {
                var reviewDatabase = new ReviewDatabase();
                revisions.Clear();
                reviewStatistics = null;
                reviews = reviewDatabase.GetReviews();
                reviewScheme = reviewDatabase.GetReviewScheme();

                var rg = new RevisionGraph(Module)
                {
                    RefsOptions = RefsFiltringOptions.All | RefsFiltringOptions.Boundary | RefsFiltringOptions.Remotes
                };
                rg.Updated += OnNewRevision;
                rg.Exited += OnRevisionsLoaded;
                rg.Execute();

            }
            catch (Exception)
            {
            }
        }

        private void OnRevisionsLoaded(object sender, EventArgs e)
        {
            reviewStatistics = revisions.Where(t => t != null)
                .GroupBy(t => t.AuthorEmail.ToLower())
                .ToDictionary(t => t.Key, CalculateReviewStatistic);
            UpdateControls();
        }

        private void UpdateControls()
        {
            forComboBox.Items.Clear();
            forComboBox.Items.AddRange(reviewStatistics.Keys.Union(reviewScheme.Revievers).ToArray());
            string userEmail = Module.GetEffectiveSetting("user.email").ToLower();
            if (reviewStatistics.ContainsKey(userEmail))
                forComboBox.SelectedItem = userEmail;
            UpdateStatisitics();
        }

        private ReviewStatistic CalculateReviewStatistic(IEnumerable<GitRevision> revisionsOfAuthor)
        {
            var statistic = new ReviewStatistic();
            foreach (GitRevision revision in revisionsOfAuthor)
            {
                string hash = revision.Guid;
                if (reviews.ContainsKey(hash))
                {
                    switch (reviews[hash].Status)
                    {
                        case ReviewStatus.Unknown:
                            statistic.NotReviewed.Add(hash);
                            break;
                        case ReviewStatus.Accepted:
                            statistic.Accepted.Add(hash);
                            break;
                        case ReviewStatus.Declined:
                            statistic.Declined.Add(hash);
                            break;
                        case ReviewStatus.Corrected:
                            statistic.Corrected.Add(hash);
                            break;
                        default:
                            statistic.NotReviewed.Add(hash);
                            break;
                    }
                }
                else
                {
                    statistic.NotReviewed.Add(hash);
                }
            }
            return statistic;
        }

        private void OnNewRevision(object sender, EventArgs e)
        {
            GitRevision revision = ((RevisionGraph.RevisionGraphUpdatedEventArgs) e).Revision;
            if (revision != null && revision.AuthorDate.Date >= fromDatePicker.Value.Date)
                revisions.Add(revision);
        }

        private void forComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatisitics();
        }

        private void UpdateStatisitics()
        {
            newCountLinkLabel.Text = "–";
            notReviewedCountLinkLabel.Text = "–";
            acceptedCountLinkLabel.Text = "–";
            declinedCountLinkLabel.Text = "–";
            correctedCountLinkLabel.Text = "–";
            myAcceptedCountLinkLabel.Text = "–";
            careLabel.Text = string.Format(careLabelPattern, string.Empty);

            string selectedDeveloper = GetSelectedDeveloper();
            ReviewStatistic toReview = GetRevisionsForReview(selectedDeveloper);
            newCountLinkLabel.Text = toReview.NotReviewed.Count.ToString();
            correctedCountLinkLabel.Text = toReview.Corrected.Count.ToString();
            acceptedCountLinkLabel.Text = toReview.Accepted.Count.ToString();

            ReviewStatistic toAttention = GetRevisionsForAttention(selectedDeveloper);
            if (!string.IsNullOrWhiteSpace(selectedDeveloper))
                careLabel.Text = string.Format(careLabelPattern,
                    selectedDeveloper.Substring(0, selectedDeveloper.IndexOf('@')));
            declinedCountLinkLabel.Text = toAttention.Declined.Count.ToString();
            notReviewedCountLinkLabel.Text = toAttention.NotReviewed.Count.ToString();
            myAcceptedCountLinkLabel.Text = toAttention.Accepted.Count.ToString();
        }

        private ReviewStatistic GetRevisionsForAttention(string selectedDeveloper)
        {
            if (reviewStatistics.ContainsKey(selectedDeveloper))
                return reviewStatistics[selectedDeveloper];
            return new ReviewStatistic();
        }

        private ReviewStatistic GetRevisionsForReview(string selectedDeveloper)
        {
            var authorsForReview = new HashSet<string>(reviewScheme.GetAuthors(selectedDeveloper));

            ReviewStatistic toReview =
                reviewStatistics.Where(t => authorsForReview.Contains(t.Key))
                    .Aggregate(new ReviewStatistic(), (s, kv) => s.Add(kv.Value));
            return toReview;
        }

        private string GetSelectedDeveloper()
        {
            string selectedDeveloper = forComboBox.SelectedIndex >= 0
                ? forComboBox.Items[forComboBox.SelectedIndex].ToString()
                : String.Empty;
            return selectedDeveloper;
        }

        private void FilterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var linkLabel = (LinkLabel) sender;
            var checkBox = (CheckBox) linkLabel.Tag;
            checkBox.Checked = true;
        }

        private void fromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            RefreshStatistic();
        }

        private void FilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (filtersUpdating) return;
            filtersUpdating = true;
            var targetCheckbox = (CheckBox) sender;
            if (targetCheckbox.Checked)
            {
                foreach (CheckBox checkbox in filterCheckboxes)
                    if (checkbox != sender)
                        checkbox.Checked = false;
            }
            IEnumerable<string> filter = filterCheckboxes.Where(t => t.Checked)
                .Select(t => t.Tag)
                .Cast<Func<IEnumerable<string>>>()
                .Select(t => t())
                .FirstOrDefault();
            RevisionGrid.RevisionsFilter = filter;
            RevisionGrid.ForceRefreshRevisions();
            filtersUpdating = false;
        }

        private class ReviewStatistic
        {
            public ReviewStatistic()
            {
                NotReviewed = new List<string>();
                Declined = new List<string>();
                Corrected = new List<string>();
                Accepted = new List<string>();
            }

            public List<string> Accepted{ get; private set; }
            public List<string> NotReviewed { get; private set; }
            public List<string> Declined { get; private set; }
            public List<string> Corrected { get; private set; }

            public ReviewStatistic Add(ReviewStatistic reviewStatistic)
            {
                NotReviewed.AddRange(reviewStatistic.NotReviewed);
                Declined.AddRange(reviewStatistic.Declined);
                Corrected.AddRange(reviewStatistic.Corrected);
                Accepted.AddRange(reviewStatistic.Accepted);
                return this;
            }
        }
    }
}