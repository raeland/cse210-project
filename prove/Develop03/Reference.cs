using System;
using System.Collections.Generic;

namespace MemorizeScriptureGame
{
  public class Reference
  {
    private string _title;
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    public Reference(string title, string book, int chapter, int verseStart) // ONE Verse
    {
      _title = title;
      _book = book;
      _chapter = chapter;
      _verseStart = verseStart;
      _verseEnd = verseStart;
    }

    public Reference(string title, string book, int chapter, int verseStart, int verseEnd) // MULTI verses
    {
      _title = title;
      _book = book;
      _chapter = chapter;
      _verseStart = verseStart;
      _verseEnd = verseEnd;
    }

    public string GetReference()
    {
      //return $"{_title} {_book} {_chapter}:{_verseStart}";
      if (_verseStart == _verseEnd)
      {
        return $"{_title} {_book} {_chapter}:{_verseStart}";
      }
      else
      {
        return $"{_title} {_book} {_chapter}:{_verseStart}-{_verseEnd}";
      }
    }

    public static Reference Parse(string referenceString)
    {
      string[] parts = referenceString.Split(')');
      if (parts.Length == 2)
      {
        string referencePart = parts[0].Trim();
        string textPart = parts[1].Trim();

        string[] referenceParts = referencePart.Split(' ');
        if (referenceParts.Length >= 3)
        {
          string title = referenceParts[0];
          string book = referenceParts[1];
          int chapter = int.Parse(referenceParts[2]);
          string[] verseParts = referenceParts[3].Split('-');
          int verseStart = int.Parse(verseParts[0]);
          //int verseEnd = int.Parse(verseParts[1]);
          int verseEnd = verseStart;
          if (verseParts.Length > 1)
          {
            verseEnd = int.Parse(verseParts[1]);
          }
          return new Reference(title, book, chapter, verseStart, verseEnd);
        }
      }
      throw new ArgumentException("Invalid reference format.");
    }
  }
}