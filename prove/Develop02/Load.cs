using System;
using System.Collections.Generic;
using System.IO;

namespace Journal
{
    public class Load
    {
        public static void _load()
        {
            string fileName = "journals.txt";
            try
            {
                if (File.Exists(fileName))
                {
                    string[] lines = File.ReadAllLines(fileName);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 3)
                        {
                            string date = parts[0].Trim();
                            string prompt = parts[1].Trim();
                            string response = parts[2].Trim();

                            Console.WriteLine($"Date: {date}\nPrompt: {prompt}\nResponse: {response}");
                            Console.WriteLine();
                        }
                    }
                    Console.WriteLine("Journal Entry Loaded Successfully");
                }
                else
                {
                    Console.WriteLine("Journal Not Found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading journal entries: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}