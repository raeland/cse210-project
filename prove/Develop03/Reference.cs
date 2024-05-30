using System;
using System.Collections.Generic;

namespace MemorizeScriptureGame
{
    public class Reference
    {
        public string _title;
        public string _book;
        public int _chapter;
        public int _verseStart;
        public int _verseEnd;

        public Reference(string title, string book, int chapter, int verseStart, int verseEnd)
        {
            _title = title;
            _book = book;
            _chapter = chapter;
            _verseStart = verseStart;
            _verseEnd = verseEnd;
        }

        public string GetReference()
        {
            return $"{_title} {_book} {_chapter} {_verseStart} {_verseEnd}";
        }

        public static Reference Parse(string referenceString)
        {
            string[] parts = referenceString.Split(" | ");
        //     string[] lines = System.IO.File.ReadAllLines(fileName);

        //     foreach (string entry in lines)
        //     {
        //         string[] parts = entry.Split(" | ");
        //         List<string> _parts = new List<string>()
        //         {
                       parts[0], parts[1], parts[2], parts[3], parts[4]
        //             parts[0], parts[1], parts[2]
        //         };
        //         entries.Add(_parts);
        //     }
        //     return entries;
        // }
        return GetReference;
        }
    }
}