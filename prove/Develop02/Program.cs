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
            bool isRunning = true;

            Load _loads = new Load();
            List<List<string>> Journal = new List<List<string>>();

            while (isRunning)
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
                        Prompt prompt = new Prompt();
                        string _prompt = prompt.PromptGenerator();
                        Console.WriteLine(prompt);
                        string response = Console.ReadLine();
                        Console.WriteLine(new Entry(_prompt, response));
                        break;
                    case "2":
                        Display._display(Journal);
                        break;
                    case "3":
                        Load._load();
                        Console.WriteLine("loading File...");
                        break;
                    case "4":
                        Save._save(Journal);
                        break;
                    case "5":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Bye Felicia");
                        return;
                }
            }
        }
    }
}