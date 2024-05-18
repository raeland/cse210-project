using System;

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
                Console.   
                break;
            case 2:
                Console.   
                break;
            case 3:
                Console.   
                break;
            case 4:
                Console.   
                break;
            case 5:
                Console.   
                break;
            default 5:
                Console.WriteLine("Quit");
                return;
                //break is a requirement in C#
                //or return; -breaks from the main method. 
                //the return statement always goes outside whatever method you are in. 
        }
        //input = Console.Read();
}
}