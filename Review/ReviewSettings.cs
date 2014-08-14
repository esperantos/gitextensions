namespace Review
{
    public static class ReviewSettings
    {
        public static string ConnectionString =
            "Server=kelite-yt-board;Port=5432;User Id=postgres;Password=kelite123;Database=review;";

        public static string[] BugTraqRegex = {@"([Kk][Ee][Ll]ite-\d+)"};
        public static string BugTraqUrl = @"https://yt.skbkontur.ru/issue/%BUGID%";
    }
}
