using System;
using System.Collections.Generic;
using System.IO;

namespace Scripture
{
    public class Verse
    {

        public List<string> _prompt;
        Random prompt = new();

        public string PromptGenerator()
        {
            _prompt = new List<string>()
            {
                "What is one thing you would re-do from today, if you could?",
                "Describe the most difficult part of your day?",
                "Where did you see the hand of the Lord in your life today?",
                "Did you learn something important today?"
            };
            int indexPrompts = prompt.Next(_prompt.Count);

            return _prompt[indexPrompts];
        }
    }
}