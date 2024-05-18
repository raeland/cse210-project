using System;

namespace Journal
{
    public class PromptGenerator
    {

    private List<string> _prompt;

    public PromptGenerator()
    {
        _prompt = new List<string>
        {
            "What is one thing you would re-do from today (good or bad), if you could?",
            "Describe the most diTicult part of your day?",
            "Did you make anyone smile today? Describe the exchange",
            "Where did you see the hand of the Lord in your life today?",
            "Did you learn something important today?"
        }
    }
    }
}