public class Comment
{
    public string _textComment;
    public string _nameOfCommenter;

    public Comment(string text, string author)
    {
        _textComment = text;
        _nameOfCommenter = author;
    }

    public string GetNameOfCommenter()
    {
        return _nameOfCommenter;
    }
    public string GetText()
    {
        return _textComment;
    }


}





    


