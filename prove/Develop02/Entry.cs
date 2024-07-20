using System;

namespace Journal
{
  class Entry
  {
    public string _entry { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }

    public Entry(string prompt, string response)
    {
      _entry = prompt;
      Response = response;
      Date = DateTime.Now;
    }
    // public static Entry Prompt() 
    // { 
    //   Prompt prompt = new Prompt(); 
    //   string entry = prompt.PromptGenerator(); 
    //   Console.Write($"{entry} "); 
    //   string response = Console.ReadLine(); 
    //   return new Entry(entry, response); 
    // }

    public override string ToString()
    {
      return $"Date: {Date}\nPrompt: {_entry}\nResponse: {Response}\n";
    }
  }
}

