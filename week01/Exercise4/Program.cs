using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program

{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> ();

        int intialNumber = -1;

        while(intialNumber!=0)
        {            
            Console.Write("Enter number ");

            string userChoice = Console.ReadLine();

            intialNumber = int.Parse(userChoice);

            if (intialNumber !=0)
            {
                numbers.Add(intialNumber);
            }
        }
        int total = 0;
        
        foreach (int number in numbers)
        {
            total += number;
        }
        Console.WriteLine($"The total is {total}");

        float average = ((float)total) / numbers.Count;

        Console.WriteLine($"The average is {average}");

        int maximum = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }
        Console.WriteLine($"The maximum is {maximum}");





    }
}