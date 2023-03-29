using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinApp
{
    public class Report
    {
        public int uid { get; set; }
        public string report { get; set; }
        public DateTime date { get; set; }
        public Report(int id, string r, DateTime d)
        {
            uid = id;
            report = r;
            date = d;
        }

    }
}
