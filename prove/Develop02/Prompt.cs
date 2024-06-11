using System;
using System.Collections.Generic;
using System.IO;

namespace Journal
{
    public class Prompt
    {
        public List<string> _prompt;
        public Random _random;
        Random prompt = new();

 public Prompt()
        {
            _prompt = new List<string>()
            {
                "What is one thing you would re-do from today, if you could?",
                "Describe the most difficult part of your day?",
                "Where did you see the hand of the Lord in your life today?",
                "Did you learn something important today?"
            };
            _random = new Random();
        }

        public string PromptGenerator()
        {
            int indexPrompts = _random.Next(_prompt.Count);
            return _prompt[indexPrompts];
            
        // public string PromptGenerator()
        // {
        //     _prompt = new List<string>()
        //     {
        //         "What is one thing you would re-do from today, if you could?",
        //         "Describe the most difficult part of your day?",
        //         "Where did you see the hand of the Lord in your life today?",
        //         "Did you learn something important today?"
        //     };
        //     int indexPrompts = prompt.Next(_prompt.Count);

        //     return _prompt[indexPrompts];
        }
    }
}