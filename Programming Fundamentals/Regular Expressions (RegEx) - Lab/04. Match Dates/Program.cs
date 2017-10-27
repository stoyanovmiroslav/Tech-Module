using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Match_Dates
{
    class Program
    {
        public static void Main()
        {
            string pattern = @"(\b\d{2})(\/|-|.)([A-Z][a-z]+)\2(\d{4})";
            string input = Console.ReadLine();

            foreach (Match date in Regex.Matches(input, pattern))
            {
                Console.Write("Day: {0}, ", date.Groups[1]);
                Console.Write("Month: {0}, ", date.Groups[3]);
                Console.WriteLine("Year: {0}", date.Groups[4]);
            }
        }
    }
}
