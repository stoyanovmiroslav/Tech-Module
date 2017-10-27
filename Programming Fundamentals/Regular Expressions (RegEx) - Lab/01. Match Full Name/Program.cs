﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Match_Full_Name
{
    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
           
            foreach (Match name in Regex.Matches(input, pattern))
            {
                Console.Write("{0} ", name.Value);
            }
        }
    }
}
