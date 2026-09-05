using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter your marks? ");

        string gradePercent = Console.ReadLine();

        int grade = int.Parse(gradePercent);

        string letter = "";

        if (grade >= 90)

        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade>= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        string sign = "";
        int lastDigit = grade%10 ;
        if (lastDigit >=7 )
        {
            sign = "+";
        }
        else if(lastDigit <=3 )
        {
            sign = "-";
        }
        else if (grade <60 || grade >93)
        {
            sign="";
        }
        else
        {
            sign="";
        }



        if (grade >= 70)
        {
            Console.WriteLine($"Congratulations! You passed with a {letter}{sign} Keep up the good work.");
        }
        else
        {
            Console.WriteLine($"You got an {letter} Stay focused and you'll get it next time. ");
        }

        

        

        

    }
}