using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Journal
{
    public class Date
    {
        private DateTime today;
        private string todayD;
        public string _date()
        {
            today = DateTime.Now;
            todayD = today.ToString();
            return todayD;
        }
    }
}