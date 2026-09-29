public class Word // creates the word class that will be used to create the word objects for the scripture memorizer program
{
    private string _text; // creates a private string variable to hold the text of the word
    private bool _isHidden; // creates a private boolean variable to hold the hidden state of the word

    public Word(string text) // creates a public constructor that takes a string parameter to intialize the text of the word and sets the hidden state to false
    {
        _text = text; // initalizes the text of the word with the parameter passed in
        _isHidden = false; // intializes the hudden state of the word to false

    }


    public void Hide() // creates a public method that sets the hidden state of the word to true
    {
        _isHidden = true; // sets the hidden state of the word to true
    }
    public void Show() // creates a public method that sets the hidden state of the word to false
    {
        _isHidden = false; // sets the hidden state of the word to false

    }
    public bool IsHidden() // creates a public method that returns the hidden state of the word
    {
        return _isHidden; // returns the hidden state of the word

    }
    
    public string GetDisplayText() // creates a public method that returns the text of the word if it is not hidden, or a string of underscores if it is hidden
    {
        
        return _isHidden ? new string('_',_text.Length) :_text; // Displays underscores if hidden, otherwise displays the actual word. The number of underscores is equal to the length of the word.
            
        
    }

    
    
}