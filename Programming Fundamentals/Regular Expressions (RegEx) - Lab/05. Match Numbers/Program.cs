using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Match_Numbers
{
    class Program
    {
        public static void Main()
        {
            string pattern = @"(^|(?<=\s))-?[0-9]+(\.\d+)?($|(?=\s))";
            string input = Console.ReadLine();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.Write("{0} ", m.Value);
            }
        }
    }
}

