using System;
using System.Collections.Generic;
using System.IO;

namespace Journal
{
    public class Load
    {
    public string _entry;
    public static List<string> _load()
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        //Load load = new Load();
        List<string> entries = _load();
        //Console.Write("Enter filename to save journal: ");
        //string filename = Console.ReadLine();
        //Console.Write("Load Journal in same folder 'Program.cs' then press 'Enter'.");
        Console.ReadLine();
        Console.Write("Enter filename: ");
        //_entry = Console.ReadLine();
        //List<string> entries = new List<string> {$"{Entry}"};
        //Journal Load = new Journal();
        //_journal = Load._load();
        
        foreach (string entry in entries)
        {
            string[] parts = entry.Split(" - ");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            return entries;
    }    
    }

    public class Save
    {
        public static void _save(List<string> entries, string fileName)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (string entry in entries)
                {
                    Console.Write(entry);
                }
            }
            Console.WriteLine("Journal Saved!");
        }  
    }
    }
}

/* ALL OF THIS IS FROM https://byui-cse.github.io/cse210-course-2023/unit02/develop.html
reading text files in C# 
string filename = "myFile.txt";
string[] lines = System.IO.File.ReadAllLines(filename);

foreach (string line in lines)
{
    string[] parts = line.Split(",");

    string firstName = parts[0];
    string lastName = parts[1];
}

Writing Text Files in C#
// Don't forget to put this at the top, so C# knows where to find the StreamWriter class
using System.IO; 

string fileName = "myFile.txt";

using (StreamWriter outputFile = new StreamWriter(filename))
{
    // You can add text to the file with the WriteLine method
    outputFile.WriteLine("This will be the first line in the file.");
    
    // You can use the $ and include variables just like with Console.WriteLine
    string color = "Blue";
    outputFile.WriteLine($"My favorite color is {color}");
}

Working with Dates in C#
DateTime theCurrentTime = DateTime.Now;
string dateText = theCurrentTime.ToShortDateString();
*/