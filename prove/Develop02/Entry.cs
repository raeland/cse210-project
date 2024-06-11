using System;

namespace Journal
{
  class Entry
{
  private string _date;
  private string _prompt;
  private string _response;

  public Entry()
  {
    _date = DateTime.Now.ToShortDateString();
    _prompt = "Did you learn something important today?";
    Console.WriteLine(_prompt);
    _response = Console.ReadLine();
  }

  public Entry (string date, string prompt, string response)
  {
    _date = date;
    _prompt = prompt;
    _response = response;
  }
  public void Display()
  {
    Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_response}");
  }

//   public void Entry (string line)
//   {
//     string[] parts = line.Split(" | ")
//   }
}
}