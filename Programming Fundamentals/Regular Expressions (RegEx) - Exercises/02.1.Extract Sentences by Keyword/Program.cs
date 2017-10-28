using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02._1.Extract_Sentences_by_Keyword
{
    class Program
    {
        public static void Main()
        {
            string paternInput = Console.ReadLine().ToLower();
            string[] input = Console.ReadLine()
                .Split(new char[] { '!', '.', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string pattern = "\\b" + paternInput + "\\b";
            Regex regex = new Regex(pattern);

            foreach (var sentence in input)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
