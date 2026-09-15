using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction(1, 2);
        Fraction fraction2 = new Fraction(3, 4);
        Fraction fraction3 = new Fraction(5, 6, 1);
        Fraction fraction4 = new Fraction(1);
        fraction1.Display();
        fraction2.Display();
        fraction3.Display();
        fraction4.Display();
        Console.WriteLine($"Decimal value of fraction1: {fraction1.GetDecimalValue()}");
        Console.WriteLine($"Decimal value of fraction2: {fraction2.GetDecimalValue()}");
        Console.WriteLine($"Decimal value of fraction3: {fraction3.GetDecimalValue()}");
        Console.WriteLine($"Decimal value of fraction4: {fraction4.GetDecimalValue()}");


    }
}