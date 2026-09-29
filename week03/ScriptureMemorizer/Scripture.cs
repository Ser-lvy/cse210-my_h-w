using System; // Gives access to basic C# features like Console.WriteLine and Random
using System.Collections.Generic; // Gives access to the List<T> class, which is used to store a collection of Scripture objects

public class Scripture // Creates the Scripture class that will be used to create the scripture objects for the scripture memorizer program
{
    private Reference _reference; // creates a private variable to store the reference of the scripture
    private List<Word> _words; // creates a private variable to store the word objects of the scripture in a list
    private Random _random; // creates a private variable to store the random object used to select a random word to hide

    public Scripture(Reference reference, string text) // creates a public constructor that takes a reference object and a string parameter to intialize the reference and text of the scripture, and creates a list of word objects from the text
    {
        _reference = reference;// saves the reference object passed in as a paramter to the private variable _reference
        _words = new List<Word>(); // creates a new list of word objects and assigns it to the private variable _words
        _random = new Random(); // creates a new random object and assigns it to the private variable _random

        string[] wordArray = text.Split(
            new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries); // splits the text of the scripture into an array of words using a space as the delimiter and removes any empty entries from the array

        foreach (string word in wordArray) // iterates through the array of words and creates a new word object for each word and adds it to the list of word objects
        {
            _words.Add(new Word(word)); // adds a new word object to the list of word objects using the word from the array as the parameter for the constructor of the word class
        }
    }

    public void HideRandomWord()
    {
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        if (visibleWords.Count == 0)
        {
            return;
        }

        int index = _random.Next(visibleWords.Count);
        visibleWords[index].Hide();
    }

    public void ShowAllWords()
    {
        foreach (Word word in _words)
        {
            word.Show();
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();

        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        return $"{_reference.GetDisplayText()}  {string.Join(" ", displayWords)}";
    }
}