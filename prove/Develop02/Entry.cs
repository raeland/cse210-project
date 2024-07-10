using System;

namespace Journal
{
  class Entry
  {
    public string _entry { get; set; }
    public string _response { get; set; }
    public DateTime _date { get; set; }

    // public Entry(string prompt, string response)
    // {
    //   _entry = prompt;
    //   _response = response;
    //   _date = DateTime.Now;
    public static Entry Prompt() 
    { 
      Prompt prompt = new Prompt(); 
      string entry = prompt.PromptGenerator(); 
      Console.Write($"{entry} "); 
      string response = Console.ReadLine(); 
      return new Entry(entry, response); 
    }

    // public override string ToString()
    // {
    //   return $"Date: {_date}\nPrompt: {_entry}\nResponse: {_response}\n";
    // }
  }
}

