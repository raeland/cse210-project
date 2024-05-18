using System;
using System.Globalization;

namespace Journal
{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Your Journal Program!");
        Console.WriteLine("Please select ONE of the options below:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("Type the number corresponding to your choice:");
        //Console.Read();
       // Journal journal = new Journal();
        
        int userInput = 0;
        //userInput = Console.ReadLine();
                //int UserInput = new input();
        //number = Console.Read();
        switch(userInput)
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
            default:
                //Quit._quit();
                Console.WriteLine("Bye Felicia");
                return;
                //break is a requirement in C#
                //or return; -breaks from the main method. 
                //the return statement always goes outside whatever method you are in. 
                // https://www.youtube.com/watch?v=y0HNk96vVLw
        }

    }
}

    //static void DisplayMessage()
    //{}
   // static void UserSelection()
    //{
      //  Console.WriteLine("Type the number corresponding to your choice:");
        //int number = int.Parse(Console.ReadLine());

        //return number;
    //}
}