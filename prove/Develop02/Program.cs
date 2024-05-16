using System;

namespace Journal
{
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Console.WriteLine("Welcome to Your Journal Program!");
        Console.WriteLine("Please select ONE of the options below:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("Type the number corresponding to your choice:");
        Console.Read();
    }
    }
}