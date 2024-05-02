using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());
        // wrong place - moved to while loop - Console.WriteLine("What is your guess? ");

        //#3 the random number part
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        //int guess = 3; //used for core assignments
        int guessCount = 0; //for guess counter in stretch assignment

        while (true)//(guess != magicNumber) //used for core assignments
        {
            Console.Write("What is your guess? ");
            //guess = int.Parse(Console.ReadLine()); //used for core assignments
            int guess = int.Parse(Console.ReadLine()); //for stretch assignment
            guessCount++; //for stretch assignment

            if (magicNumber < guess)
            {
                Console.WriteLine("Lower ");
            }
                else if (magicNumber > guess)
                {
                    Console.WriteLine("Higher ");
                }
                    else
                    {
                        Console.WriteLine("You Guessed Correctly! ");
                        break;
                    }
        }        
        Console.WriteLine($"And you did it in {guessCount} tries!!! ");//for stretch assignment
    }
}