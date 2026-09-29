public class Reference // creates the reference class that will be used to create the reference objects for the scripture memorizer program
{
    private string _book; // stores the name of the bible book
    private int _chapter; // stores the chapter number
    private int _verse; // stores the verse number
    private int _endVerse; // stores the ending verse when there is a range of verses

    public Reference(string book, int chapter, int verse) // Constructor for a reference with a single verse
    {
        _book = book; // stores the name of the bible book
        _chapter = chapter; // stores the chapter number
        _verse = verse; // stores the verse number
    }
    public Reference(string book, int chapter, int verse, int endVerse) // Constructor for a reference with a range of verses
    {
        _book = book; // stores the name of the bible book
        _chapter = chapter; // stores the chapter number
        _verse = verse; // stores the verse number
        _endVerse = endVerse; // stores the ending verse when there is a range of verses
    }
    
   

    public string GetDisplayText() // creates a public method that returns the reference in a formatted string
    {
        if (_endVerse >0) // checks if there is an ending verse, and if so, returns the reference in the format "Book Chapter:Verse-EndVerse"
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse})"; // returns the reference in a formatted string
        }
        else // if there  is no ending verse, returns the reference in the formatted string "Book Chapter:Verse"
        {
            return $"{_book} {_chapter}:{_verse})"; // returns the reference in a formatted string

        }
    }
    

    
}