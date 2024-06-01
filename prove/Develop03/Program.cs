using System;
using System.IO;

namespace MemorizeScriptureGame
{
class Program
{
    static void Main(string[] args)
    {
        BookShelf shelf = new BookShelf();

        shelf.AddScripture(new Reference("The Doctrine and Covenants", "Section", 138, 57), "I beheld that the faithful elders of this dispensation,when they depart from mortal life, continue their labors in the preaching of the gospel of repentance and redemption, through the sacrifice of the Only Begotten Son of God, among those who are in darkness and under bondage of sin in the great world of the spirits of the dead.");
        shelf.AddScripture(new Reference("The Doctrine and Covenants", "Section", 138, 39), "And our glorious Mother Eve, with many of her faithful daughters who had lived through the ages and worshiped the true and living God.");
        shelf.AddScripture(new Reference("The New Testament", "James 1", 1, 3, 4), "Knowing this, that the trying of your faith worketh patience. But let patience have her perfect work, that ye may be perfect and entire, wanting nothing.");
        
        while (true)
        {
            Console.Clear();
            Scripture scripture = shelf.SelectRandomScripture();

            if (scripture != null)
            {
                bool memorized = false;

                while (!scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.RenderScripture());

                    Console.Write("Press Enter to hide a word or type 'quit' to exit: ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "quit")
                        return;

                    scripture.HideRandom();

                    if (scripture.IsCompletelyHidden())
                    {
                        memorized = true;
                        break;
                    }
                }

                if (memorized)
                {
                    Console.Clear();
                    Console.WriteLine("Okay Scriptorian! Way to Go!!!!");
                    Console.WriteLine("Press Enter to learn another scripture...");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("The scripture shelf is empty. Add scriptures or load them from files.");
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
                return;
            }
        }
    }
}
}