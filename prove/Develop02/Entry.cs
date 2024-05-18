using System;

namespace Journal
{
    public class Entry
    {
        //public string _entry;
        //public string _date;
    public static void _entry()//(string date, string entry)
    {
        _date = date;
        _entry = entry;
    }
        //public string LoadEntry()
        //{
           // return ($"{_date}{_entry}");
        //}    
    }
}

foreach (List<string> entry in Entry)
{
    Console.WriteLine();
    Console.WriteLine($"Entry:{_date}");
    Console.WriteLine($"Random Prompt: {_prompt}");
    Console.WriteLine($"Your Response: {entry} ");
}
        //Console.ReadLine();
            //return ($"{_date}{_entry}");
        }    
    }
}