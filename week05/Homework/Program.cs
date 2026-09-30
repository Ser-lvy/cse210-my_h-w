using System;

class Program
{
    static void Main(string[] args)
    {
        

        Assignment assignment1 = new Assignment("Levi","Algebra");
        string summary1  = assignment1.GetSummary();

        MathAssignment math = new MathAssignment("Malesh","Acids and Bases", "A-B","1-5");
        
        string Math = math.GetHomeworkList();


        Console.WriteLine(summary1);
        Console.WriteLine(Math);

        WritingAssignment writing = new WritingAssignment("Praise", "Fitness","First Day at the Gym");
        string writingg = writing.GetWritingInformation();

        Console.WriteLine(writingg);

    }
}