public class Video
{
    public string _title;
    public string _creator;
    public int _lengthInSeconds;
    public List<Comment> _comments;

    public Video(string title, string creator, int lengthInSeconds)
    {
        _title = title;
        _creator = creator;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetCreator()
    {
        return _creator;
    }
    public int GetLength()
    {
        return _lengthInSeconds;
    }
    public int GetCommentCount()
    {
        return _comments.Count;
    }
    public List<Comment> GetComments()
    {
        return _comments;
    }
}