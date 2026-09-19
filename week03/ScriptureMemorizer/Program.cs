using System;
using System.Collections.Generic;
using System.IO;

// To exceed expectations, i added the feature of loading scriptures from a text file. 
// I added a few default scriptures to the file if it does not exist.

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = LoadScripturesFromFile("scriptures.txt");

        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found.");
            return;
        }

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide a word or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input != null && input.ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                return;
            }

            scripture.HideRandomWord();
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("All words are hidden. Press Enter to exit.");
        Console.ReadLine();
    }

    static List<Scripture> LoadScripturesFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            CreateScriptureFile(filename);
        }

        List<Scripture> scriptures = new List<Scripture>();
        string[] lines = File.ReadAllLines(filename);

        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i].Trim();

            if (line == "")
            {
                continue;
            }

            string referenceLine = line;
            string textLine = "";

            if (i + 1 < lines.Length)
            {
                textLine = lines[i + 1].Trim();
                i++;
            }

            if (textLine != "")
            {
                Reference reference = ParseReference(referenceLine);
                scriptures.Add(new Scripture(reference, textLine));
            }
        }

        return scriptures;
    }

    static void CreateScriptureFile(string filename)
    {
        string[] setContent = {
            "John 3:16",
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.",
            "",
            "Proverbs 3:5-6",
            "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.",
            "",
            "Philippians 4:13",
            "I can do all this through him who gives me strength.",
            "",
            "Psalm 23:1",
            "The Lord is my shepherd, I lack nothing."
        };

        File.WriteAllLines(filename, setContent);
        Console.WriteLine("Created default scriptures.txt file.");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    static Reference ParseReference(string referenceText)
    {
        string[] parts = referenceText.Split(' ');
        string book = parts[0];
        string chapterVerse = parts[1];

        string[] chapterAndVerse = chapterVerse.Split(':');
        int chapter = int.Parse(chapterAndVerse[0]);
        string versePart = chapterAndVerse[1];

        if (versePart.Contains("-"))
        {
            string[] verses = versePart.Split('-');
            int startVerse = int.Parse(verses[0]);
            int endVerse = int.Parse(verses[1]);

            return new Reference(book, chapter, startVerse, endVerse);
        }
        else
        {
            int verse = int.Parse(versePart);

            return new Reference(book, chapter, verse);
        }
    }
}