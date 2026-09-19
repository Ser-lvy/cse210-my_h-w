public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapyer, int verse)
    {
        _book = book;
        _chapter = chapyer;
        _verse = verse;
    }
    public Reference(string book, int chapyer, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapyer;
        _verse = verse;
        _endVerse = endVerse;
    }
    
   

    public string GetDisplayText()
    {
        if (_endVerse >0)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse})";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse})";

        }
    }
    

    
}