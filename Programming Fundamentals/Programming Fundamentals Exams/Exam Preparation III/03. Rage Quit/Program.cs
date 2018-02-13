using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([^0-9]+)([0-9]+)";
            StringBuilder sb = new StringBuilder();

                foreach (Match m in Regex.Matches(input, pattern))
                {                 
                    int lenght = int.Parse(m.Groups[2].ToString());
                    for (int i = 0; i < lenght; i++)
                    {
                        sb.Append(m.Groups[1].ToString().ToUpper());
                    }
                }
            
            List<char> uniqueSimbols = sb.ToString().ToCharArray().Distinct().ToList();
            Console.WriteLine($"Unique symbols used: {uniqueSimbols.Count}");
            Console.WriteLine(sb);
        }
    }
}

