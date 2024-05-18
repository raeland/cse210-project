using System;
using System.Collections.Generic;
using System.IO;

namespace Journal
{
    public class Load
    {
    public string _entryFiles;
    public List<string> _load()
    {
        Load load = new Load();
        List<string> entries = load._load();
        Console.Write("Enter filename to save journal: ");
        string filename = Console.ReadLine();
        //Console.Write("Load Journal in same folder 'Program.cs' then press 'Enter'.");
        Console.ReadLine();
        Console.Write("Enter filename: ");
        _entryFiles = Console.ReadLine();
        List<string> entries = new List<string> {$"{Entry}"};
        //Journal Load = new Journal();
        //_journal = Load._load();
        
        foreach (string entry in entries)
        {
            Console.WriteLine();
            Console.WriteLine($"Entry:{_date}");
            Console.WriteLine($"Random Prompt: {_prompt}");
            Console.WriteLine($"Your Response: {entry}");
        }
            return entries;
    }    
    }

    public class Save
    {
        public static void _save(List<string> entries, string filename)
        {
          try{
            using(string Entry = new Entry)
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