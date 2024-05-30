using System;

namespace MemorizeScriptureGame
{
    class Program
{
    static void Main(string[] args)
    {
        LibraryScripture _scripture = new LibraryScripture(); //instantiate
        
        _scripture.ScriptureLibrary()
        

        while (true)
        {
            Console.Clear();
            Scripture _scripture = _scripture.ScriptureLibrary();

            if (_scripture != null)
            {
                bool memorized = false;

                while (!_scripture.HideAll())
                {
                    Console.Clear();
                    Console.WriteLine(_scripture.RenderScripture());

                    Console.Write("press Enter to hide a word or type 'quit' to exit: ");
                    string input = Console.ReadLine();

                    if (input() == "quit")
                    return;

                    _scripture.HideRandom();

                    if (_scripture.HideAll())
                    {
                        memorized = true;
                        break;
                    }
                }

                if (memorized)
                {
                    Console.Clear();
                    Console.WriteLine("Okay Scriptorian! Way to Go!!!");
                    Console.WriteLine("Press Enter to hide more words ");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Press Enter to exit.");
                return;
            }
        }
    }
}
}

//        Console.WriteLine("..Oh, what can I say more...");
        //store "The Doctrine and Covenants 138:57"
        // "I beheld that the faithful elders of this dispensation, 
        // when they depart from mortal life, continue their labors 
        // in the preaching of the gospel of repentance and redemption, 
        // through the sacrifice of the Only Begotten Son of God, 
        // among those who are in darkness 
        // and under bondage of sin in the great world of the spirits of the dead."

        // store "The Doctrine and Covenants 138:39"
        // "And our glorious Mother Eve, with many of her faithful daughters 
        // who had lived through the ages and worshiped the true and living God."

        // clear console screen 
            /* // This will start by displaying "AAA" and waiting for the user to press the enter key
                Console.WriteLine("AAA");
                Console.ReadLine();

                // This will clear the console
                Console.Clear();

                // This will show "BBB" in the console where "AAA" used to be
                Console.WriteLine("BBB");
            */
        // display complete scripture, with reference
        // prompt user to press enter key or type quit
        // typing quit MUST end program 

        // hitting enter key should hide few random words. 
        // clear the console and display scripture in the entirety with reference 

        // When all words are hidden program should end

        // core requirements - select any random word(s) even if already hidden

        // MUST contain 3 classes in addition to Program Class 
            //1.scripture 2.reference (verse range constructor included) 3.represent a word in scripture