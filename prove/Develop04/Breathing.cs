using System;

namespace Mindfullness
{
    public class Breathing : Activity
    {
        public Breathing(int time) : base("Breathing", "This activity will help you relax by walking you through breathing in and out s-l-o-w-l-y. ", time)
        {}

        public void StartActivity()
        {}
        protected override void ShowPrompt(int time)
        {
            Console.WriteLine("Clear your mind and focus on your breathing.");
            if (time % 2 == 1)
                Console.WriteLine("Breathe in...");
            else
                Console.WriteLine("Breathe out...");
            ShowAnimation();
            Thread.Sleep(1000);
        }
    }
}

// How long, in seconds, would you like your session to last?
// Get ready...
// Breathe in... (counts down at each interval)