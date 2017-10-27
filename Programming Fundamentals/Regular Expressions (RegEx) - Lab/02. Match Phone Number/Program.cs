using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Match_Phone_Number
{
    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";

            List<string> result = new List<string>();
            foreach (Match m in Regex.Matches(input, pattern))
            {
                result.Add(m.Value);
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
