using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Why does it always have to be math?!");
        
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValuel());
        
        Fraction fraction2 = new Fraction(7);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(6,6);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
        
    }
}