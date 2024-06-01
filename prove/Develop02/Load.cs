using System;
using System.Collections.Generic;
using System.IO;

namespace Journal
{
    public class Load
    {
        public string _entry;
        public List<List<string>> Entries = new List<List<string>>();
        public List<List<string>> _loadFile()
        {
            string fileName;
            Console.Write("Enter file name: ");
            fileName = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string entry in lines)
            {
                string[] parts = entry.Split(" | ");
                List<string> _parts = new List<string>()
                {
                    parts[0], parts[1], parts[2]
                };
                Entries.Add(_parts);
            }
            return Entries;
        }
    }
}