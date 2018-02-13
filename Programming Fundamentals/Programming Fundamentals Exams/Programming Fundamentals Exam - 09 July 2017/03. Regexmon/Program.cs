using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patternDidimon = @"([^A-Za-z-]+)(.*)";
            string patternBojomon = @"(([A-Za-z]+)-([A-Za-z]+))(.*)";

            string leftString = input;
            while (leftString != "")
            {
                leftString = didimonMatches(leftString, patternDidimon);
                if (leftString == "")
                break;
                leftString = bojomonMatches(leftString, patternBojomon);
            }
        }

        private static string didimonMatches(string leftString, string patternDidimon)
        {
            Regex regexDidimon = new Regex(patternDidimon);
            Match matchDidimon = regexDidimon.Match(leftString);
            if (matchDidimon.Success)
            {
                leftString = (matchDidimon.Groups[2].ToString());
                Console.WriteLine("{0}", matchDidimon.Groups[1]);
                return leftString;
            }
            else
            {
                leftString = "";
                return leftString;
            }
        }

        private static string bojomonMatches(string leftString, string patternBojomon)

        {
            Regex regexBojomon = new Regex(patternBojomon);
            Match matchrBojomon = regexBojomon.Match(leftString);

            if (matchrBojomon.Success)
            {
                leftString = (matchrBojomon.Groups[4].ToString());
                Console.WriteLine("{0}", matchrBojomon.Groups[1]);
                return leftString;
            }
            else
            {
                leftString = "";
                return leftString;
            }
        }
    }
}
