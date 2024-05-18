using System;

namespace Journal
{
    public class Entry
    {
    private string _date;
    private string _entry;

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