using System;
using System.IO;
using System.Collections.Generic;
using System.Linq.Expressions;


class Program
{
    static void Main(string[] args)

    //I added try and catch exceptions in my program to protect and prevent
    // my program from crashing when invalid or wrong entries are made
    {
        try
        {

            Journal journal = new Journal();
            Prompts prompts = new Prompts();

            bool running = true;
            while (running)
            {
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");

                Console.WriteLine("What would you like to do? ");
                string choice = Console.ReadLine();

                if (choice =="1")
                {
                    string prompt = prompts.GetRandomPrompt();

                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    string date = DateTime.Now.ToShortDateString();

                    Entry entry = new Entry(date, prompt, response);

                    journal.AddEntry(entry);

                } 
                else if (choice == "2")
                {
                journal.DisplayEntries();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("What is the File name? ");
                    string filename = Console.ReadLine();

                    journal.LoadFromFile(filename);
                }
                else if (choice == "4")
                {
                    Console.WriteLine("What is the filename? ");
                    string filename = Console.ReadLine();

                    journal.SaveToFile(filename);

                }

                else if (choice == "5")
                {
                    running = false;

                }
                else
                {
                    Console.WriteLine("Invalid choice Please try again");
                }
                Console.WriteLine();
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine("Something unexpected happened");
            Console.WriteLine($"Error: {ex.Message}");
        }
        

    }
}