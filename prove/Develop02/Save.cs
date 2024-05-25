using System;
using System.Xml.Linq;
using Journal;

namespace Journal
{
    public class Save
    {
        public static void _save(List<List<string>> entries)
        {
            Console.WriteLine("Enter file name: ");
            string fileName = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (List<string> entry in entries)
                {
                    outputFile.WriteLine($"{entry[0]} | {entry[1]} | {entry[2]}");
                }
            }
            Console.WriteLine("Journal Saved!");
        }
    }
}