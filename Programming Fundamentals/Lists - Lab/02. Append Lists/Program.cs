using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                   .Split('|')
                   .ToList();

            List<string> result = new List<string>();

            numbers.Reverse();

            for (int i = 0; i < numbers.Count; i++)
            {
                string[] tokens = numbers[i]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                result.AddRange(tokens);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
