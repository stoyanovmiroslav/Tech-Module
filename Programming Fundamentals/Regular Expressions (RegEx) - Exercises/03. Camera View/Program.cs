using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skipTake = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string[] input = Console.ReadLine()
                .Replace("|<", "|< ")
                .Split(new string[] { "|<" }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string result = " ";
            for (int i = 0; i < input.Length; i++)
            {
                string newString = input[i];
                if (newString[0] == ' ') 
                {
                    for (int j = skipTake[0] + 1; j <= (skipTake[0] + skipTake[1]); j++)
                    {
                        if (j == (newString.Length))
                        {
                             break;
                        }
                           
                        result += newString[j];
                    }
                    result += " ";
                }
            }
            List<string> finalResult = result.Trim(' ').Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries ).ToList();
            Console.WriteLine(String.Join(", ", finalResult));
        }
    }
}
