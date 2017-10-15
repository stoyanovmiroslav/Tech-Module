using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                           .Split(' ')
                           .Select(double.Parse)
                           .ToArray();

            var count = new SortedDictionary<double, int>();

            foreach (var currentNumber in input)
            {
                if (count.ContainsKey(currentNumber))
                    count[currentNumber]++;
                else count[currentNumber] = 1;
            }

            foreach (var leftnumbers in count.Keys)
            {
                Console.WriteLine($"{leftnumbers} -> {count[leftnumbers]}");
            }
        }
    }
}
