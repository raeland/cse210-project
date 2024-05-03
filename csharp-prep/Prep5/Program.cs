using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Program!");
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Please enter your favorite number: ");
        string favoriteNumber = Console.ReadLine();
        
        favoriteNumber = int.Parse(favoriteNumber);
        
        int sq = 1;

        while (sq < favoriteNumber / sq)
        {
            sq++;
        }
        if (sq > favoriteNumber / sq)
            return sq - 1;
            return sq;
    }
        Console.WriteLine($"Your name is {name}, the square of your favorite number {favoriteNumber} is {square}.");
    }
