using System;
// I exceeded the requirements for the Reflection and Listing activities by implementing a Fisher-Yates
// shuffle so prompts and questions are shown without repeats, giving the user
// a fresh, non-duplicating experience every session.


class Program
{
    static void Main(string[] args)
    {
        
        string menuChoice = "";

        while (menuChoice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            menuChoice = Console.ReadLine() ?? "";

            switch (menuChoice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Run();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(1500);
                    break;
            }
        }
    }

}