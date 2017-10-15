using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine()
                          .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(decimal.Parse)
                          .ToList();

            bool hasSummed = true;

            while (hasSummed)
            {
                hasSummed = false;
                decimal sumOfNumbers = 0.0M;

                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] == numbers[i - 1])
                    {
                        sumOfNumbers = numbers[i] + numbers[i - 1];
                        numbers.Insert(i + 1, sumOfNumbers);
                        numbers.RemoveRange(i - 1, 2);
                        hasSummed = true;
                        break;
                    }
                }
            }
         Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
