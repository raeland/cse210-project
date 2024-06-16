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

        public void StartActivity()
        {}
        protected override void ShowPrompt(int time)
        {
            Random random = new Random();
            int randomTime = random.Next(_reflectionPrompts.Length);
            Console.WriteLine(_reflectionPrompts[randomTime]);
            ShowAnimation();
            Thread.Sleep(1000);
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