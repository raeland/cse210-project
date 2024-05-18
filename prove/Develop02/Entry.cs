using System;

namespace Journal
{
    public class Entry
    {
        public string _entry;
        public string _date;
    public Entry(string date, string entry)
    {
        _date = date;
        _entry = entry;
    }
        public string LoadEntry()
        {
            return ($"{_date}{_entry}");
        }    
    }
}