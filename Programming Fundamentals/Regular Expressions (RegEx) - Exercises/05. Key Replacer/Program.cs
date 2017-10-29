using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputPattern = Console.ReadLine()
                                  .Split(new string[] { "|", "<", "\\" }, StringSplitOptions.RemoveEmptyEntries)
                                  .ToArray();

            string input = Console.ReadLine();
            string pattern = @"(?<="+ inputPattern[0] +")(.*?)(?="+ inputPattern[2] +")";
            string output = "";
            foreach (Match m in Regex.Matches(input, pattern))
            {
                    output += m.Value;
            }
            if (output.Length > 0)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Empty result");
            }
           
        }
    }
}
