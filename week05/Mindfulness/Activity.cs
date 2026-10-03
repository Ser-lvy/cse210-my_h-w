using System.Diagnostics;
using System. Threading;

public abstract class Activity
{
    
    private string _description;
    private string _name;
    protected int _duration;

    public Activity(string description , string name)
    {
        _description = description;
        _name = name; 
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.WriteLine("How long in seconds would you like this activity to take?");
        _duration = int.Parse(Console.ReadLine() ?? "0");
        Console.Clear();
        Console.WriteLine("Get Ready....");
        ShowSpinner(3);

    }
    public void ShowSpinner(int seconds)
    {
        List<string> spinnerStrings = new List<string> { "|", "/", "-", "\\" };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinnerStrings[i];
            Console.Write(s);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i++;
            if (i >= spinnerStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

     
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
    }

    
    public abstract void Run();
}



    
