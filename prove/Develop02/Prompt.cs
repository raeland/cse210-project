using System;
using System.Collections.Generic;
using System.IO;

namespace Journal
{
    public class PromptGenerator
    {

    public List<string> _prompt;

        public PromptGenerator()
        {
        
            _prompt = new List<string>
            {
            "What is one thing you would re-do from today, if you could?",
            "Describe the most difficult part of your day?",
            "Did you make anyone smile today? Describe the exchange.",
            "Where did you see the hand of the Lord in your life today?",
            "Did you learn something important today?"
            };
        }
    }
} //WHYYYYYYY does it still show an error. I can't figure it out