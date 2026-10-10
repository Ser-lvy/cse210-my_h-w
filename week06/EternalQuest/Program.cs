using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        static void RecordEvent(GoalManager goalManager)
        {
            Console.Write("Enter the index of the goal to record an event (1-based index): ");
            int goalIndex = int.Parse(Console.ReadLine()) - 1;

            if (goalIndex >= 0 && goalIndex < goalManager.GetGoals().Count)
            {
                goalManager.RecordEvent(goalIndex);
                Console.WriteLine("Event recorded successfully.");
            }
            else
            {
                Console.WriteLine("Invalid goal index.");
            }
        }
        static void CreateNewGoal(GoalManager goalManager)
        {
            Console.WriteLine("Select the type of goal to create:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Enter your choice: ");
            string goalTypeChoice = Console.ReadLine();

            Console.Write("Enter the short name of the goal: ");
            string shortName = Console.ReadLine();
            Console.Write("Enter the description of the goal: ");
            string description = Console.ReadLine();
            Console.Write("Enter the points for the goal: ");
            int points = int.Parse(Console.ReadLine());

            Goal newGoal;

            switch (goalTypeChoice)
            {
                case "1":
                    newGoal = new SimpleGoal(shortName, description, points);
                    break;
                case "2":
                    newGoal = new EternalGoal(shortName, description, points);
                    break;
                case "3":
                    Console.Write("Enter the target count for the checklist goal: ");
                    int targetCount = int.Parse(Console.ReadLine());
                    newGoal = new ChecklistGoal(shortName, description, points, targetCount);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Goal creation canceled.");
                    return;
            }

            goalManager.AddGoal(newGoal);
            Console.WriteLine("Goal created successfully.");
        }
        GoalManager goalManager = new GoalManager();
        string filename = "goals.txt";

        // Load goals from file if it exists
        if (File.Exists(filename))
        {
            goalManager.LoadGoals(filename);
        }

        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(goalManager);
                    break;
                case "2":
                    goalManager.DisplayGoals();
                    break;
                case "3":
                    goalManager.SaveGoals(filename);
                    Console.WriteLine("Goals saved successfully.");
                    break;
                case "4":
                    goalManager.LoadGoals(filename);
                    Console.WriteLine("Goals loaded successfully.");
                    break;
                case "5":
                    RecordEvent(goalManager);
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
        