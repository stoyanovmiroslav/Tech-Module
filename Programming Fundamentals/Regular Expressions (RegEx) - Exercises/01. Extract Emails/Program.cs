using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class Program
    {
        public static void Main()
        {
            string pattern = @"(?<=\s)([a-z]+([-.][a-z]+)?)@([a-z-_]+[.][a-z]+)([.][a-z]+)?";
            string input = Console.ReadLine();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine("{0} ", m.Value);
            }
        }
    }
}
