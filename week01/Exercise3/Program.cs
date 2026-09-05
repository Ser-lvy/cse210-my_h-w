using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1,101);

        int guess = -1;

        //Console.Write("What is the Magic number? ");
        //Console.WriteLine($"{magicNumber}");

        //Console.Write("What is your guess? ");

        //string user = Console.ReadLine();
        //int userInput = int.Parse(user);

        while(guess!= magicNumber)
        {
            Console.Write("What is your guess? ");
             guess = int.Parse(Console.ReadLine());



            if (guess > magicNumber)
            {
                Console.WriteLine("Lower!");
            }
            else if( guess < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            else
            {
                Console.WriteLine("You guessed it");
            }
        }
    

    }
}