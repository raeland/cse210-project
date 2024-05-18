using System;
using System.Collections.Generic;
using System.IO;

namespace Journal
{
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
