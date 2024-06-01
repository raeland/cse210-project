using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Journal
{
    class Program
    {
        static void Main(string[] args)

        {
            bool program = false;

            Load _loads = new Load();
            List<List<string>> Journal = new List<List<string>>();

            while (!program)
            {
                Console.WriteLine("Welcome to Your Journal Program!");
                Console.WriteLine("Please select ONE of the options below:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Type the number corresponding to your choice:");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        // Entry entry = Entry.prompt();
                        // List<string> journalEntry = new List<string>();
                        // Journal.Add(journalEntry);
                        break;
                    case "2":
                        Display._display(Journal);
                        break;
                    case "3":
                        Journal = _loads._loadFile();
                        Console.WriteLine("loading File...");
                        break;
                    case "4":
                        Save._save(Journal);
                        break;
                    case "5":
                        program = true;
                        break;
                    default:
                        //Quit._quit();
                        Console.WriteLine("Bye Felicia");
                        return;
                        //break is a requirement in C#
                        //or return; -breaks from the main method. 
                        //the return statement always goes outside whatever method you are in. 
                        // https://www.youtube.com/watch?v=y0HNk96vVLw
                }
            }
        }
    }
}