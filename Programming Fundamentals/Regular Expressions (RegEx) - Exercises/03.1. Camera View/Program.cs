using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03._1.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skipTake = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string input = Console.ReadLine();
            string pattern = @"\|<[^\|<]*";

            List<string> allWords = new List<string>();
            foreach (Match m in Regex.Matches(input, pattern))
            {
                char[] word = m.Value.Skip(skipTake[0] + 2).Take(skipTake[1]).ToArray();
                allWords.Add(string.Join("", word));
            }
            Console.WriteLine(String.Join(", ", allWords));
        }
    }
}
