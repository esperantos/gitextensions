namespace Review
{
    public class ReviewInfo
    {
        public string CommitHash { get; set; }
        public ReviewStatus Status { get; set; }
        public string Comment { get; set; }
        public string ChangeAuthor { get; set; }
    }
}