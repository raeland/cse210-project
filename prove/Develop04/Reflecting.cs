using System;

namespace Mindfullness
{
    public class Reflecting : Activity
    {
        private string[] _reflectionPrompts = new string[]
        {
        "Think of a time when you did something really difficult.",
        "Think of a time when you did something selfless.",
        "Think of a time when you were kind when you didn't want to be.",
        "Think of a time when you wanted to scream and didn't."
        };

        public Reflecting(int time) : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience.", time)
        {}

        public new void StartActivity()
        {Console.WriteLine($"Begin Your Mindfulness Journey with the {_activityName} Activity");
            Console.WriteLine($"{_activityDescription}");
            Thread.Sleep(3000);

            Random random = new Random();
            string prompt = _reflectionPrompts[random.Next(_reflectionPrompts.Length)];
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine(prompt);
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            Console.WriteLine("You may begin in:");
            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

            for (int i = 1; i <= _time; i++)
            {
                ShowPrompt(i);
            }

            EndActivity();
        }
        protected override void ShowPrompt(int time)
        {
            Console.WriteLine("How did you feel when it was complete?");
            ShowAnimation();
            Thread.Sleep(1000);

            Console.WriteLine("What is your favorite thing about this experience?");
            ShowAnimation();
            Thread.Sleep(1000);

            // Random random = new Random();
            // int randomTime = random.Next(_reflectionPrompts.Length);
            // Console.WriteLine(_reflectionPrompts[randomTime]);
            // ShowAnimation();
            // Thread.Sleep(1000);
        }
                    // Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }
}

// How long, in seconds, would you like your session to last?



// Get ready...


// Consider the following prompt:
// --- ---
// When you have something in mind, press enter to continue.

// Now ponder on each of the following questions as they related to this experience.

// You may begin in : (counts down at each interval)
// How did you feel when it was complete? (spinning dash)
// What is your favorite thing about this experience? (spinning dash)

// Well DONE!!
// (spinning dash)
// You've completed another [int] seconds of the Reflecting Activity.