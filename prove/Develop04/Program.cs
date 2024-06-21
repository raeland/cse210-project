using System;
using System.Diagnostics;
using System.Reflection;

namespace Mindfullness
{
    class Program
    {
        static void Main(string[] args)
        {
            bool program = false;

            while (!program)
            {
                Console.WriteLine("Mindfullness to Unlock Peace");
                Console.WriteLine("Please select ONE of the options below:");
                Console.WriteLine("1. Breathe Work");
                Console.WriteLine("2. Make Lists");
                Console.WriteLine("3. Reflection");
                Console.WriteLine("4. Quit");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Breathing Breathing = new Breathing(5);
                        Breathing.StartActivity();
                        break;
                    case "2":
                        Listing Listing = new Listing(5);
                        Listing.StartActivity();
                        break;
                    case "3":
                        Reflecting Reflecting = new Reflecting(5);
                        Reflecting.StartActivity();
                        break;
                    case "4":
                    Console.Clear();
                        Console.WriteLine("Bye Felicia!");
                        return;
                    default:
                        Console.WriteLine("Try again");
                        return;
                }
            }
        }
    }
}