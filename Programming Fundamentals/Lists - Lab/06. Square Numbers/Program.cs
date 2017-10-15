using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                       .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                       .Select(double.Parse)
                       .ToList();

            numbers.Sort();
            numbers.Reverse();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
                {
                    Console.Write("{0} ", numbers[i]);
                }
            }
        }
    }
}
