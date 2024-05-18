using System;
using System.Xml.Linq;

namespace Journal
{
    public class Journal
{
    public static void Menu()
    {
        {
            Console.WriteLine("What would you like to do? ");
            Console.WriteLine("1. Entry ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Quit ");
            Console.WriteLine("Type the number corresponding to your choice: ");
        }

        int input = 1;
        input = Console.Read();
        switch(input)
        {
            case 1:
                Entry._entry();   
                break;
            case 2:
                Display._display();   
                break;
            case 3:
                Load._load();   
                break;
            case 4:
                Save._save();
                break;
            case 5:
                Quit._quit();   
                break;
            default 5:
                Console.WriteLine("Bye Felicia");
                return;
                //break is a requirement in C#
                //or return; -breaks from the main method. 
                //the return statement always goes outside whatever method you are in. 
                // https://www.youtube.com/watch?v=y0HNk96vVLw
        }
        //input = Console.Read();
}
}