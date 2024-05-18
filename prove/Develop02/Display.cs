using System;

namespace Journal
{
    public class Display
    {
    public static void _display()
    {
        Console.WriteLine($"{_date} {_prompt} {_entry}"); 
        Console.ReadLine();
            //return ($"{_date}{_entry}");
        }    
    }
}