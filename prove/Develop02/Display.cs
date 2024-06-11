using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace Journal
{
    public class Display
    {
        public static void _display(List<List<string>> Journal)
        {
            foreach (List<string> entry in Journal)
            {
                Console.WriteLine($"{entry[0]} {entry[1]}{entry[2]}");
                //Console.WriteLine;
            }
        }
    }
}