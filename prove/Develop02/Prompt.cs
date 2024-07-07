using System;
using System.Collections.Generic;
using System.IO;

namespace Journal
{
    public class Prompt
    {
        private List<string> _prompts;
        public Random _random;

        public Prompt()
        {
            _prompts = new List<string>
            {
                "What is one thing you would re-do from today, if you could?",
                "Describe the most difficult part of your day?",
                "Where did you see the hand of the Lord in your life today?",
                "Did you learn something important today?"
            };
        }

        public string PromptGenerator()
        {
            Random _random = new Random();
            int indexPrompts = _random.Next(_prompts.Count);
            return _prompts[indexPrompts];
        }
    }
}