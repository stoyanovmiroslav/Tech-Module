using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Match_Hexadecimal_Numbers
{
    class Program
    {
        public static void Main()
        {
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";
            string input = Console.ReadLine();
           
            foreach (Match hexNumbers in Regex.Matches(input, pattern))
            {
                Console.Write("{0} ", hexNumbers.Value);
            }
        }
    }
}
