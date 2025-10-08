namespace OBED.Include
{
    class Profile(string name, long userID)
    {
        public string Name { get; private set; } = name;
        public long UserID { get; private set; } = userID;
    }

    enum UserAction
    {
        RatingRequest,
        CommentRequest,
        NoActiveRequest
    }

    class UserState()
    {
        public UserAction? Action { get; set; }
        public string? RefTo { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
    }

    class Reviev(long fromID, int rating, string? comment = null)
    {
        public long FromID { get; private set; } = fromID;
        public int Rating { get; private set; } = rating;
        public string? Comment { get; private set; } = comment;
    }
}
