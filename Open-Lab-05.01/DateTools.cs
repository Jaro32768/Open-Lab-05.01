using System;

namespace Open_Lab_05._01
{
    public class DateTools
    {
        public string Century(int year)
        {
            int a = year + 99;
            int b = a / 100;
            string c = b.ToString();
            string d;
            if (c.EndsWith("11") || c.EndsWith("12") || c.EndsWith("13" ))
                d = c + "th century";
            else if (c.EndsWith("1"))
                d = c + "st century";
            else if (c.EndsWith("2"))
                d = c + "nd century";
            else if(c.EndsWith("3"))
                d = c + "rd century";
            else
                d = c + "th century";
            return d;
        }
    }
}
