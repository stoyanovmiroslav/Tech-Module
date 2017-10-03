using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);

            int theSum = MultiplyEvensOdds(number);
            Console.WriteLine(theSum);
        }

        private static int MultiplyEvensOdds(int number)
        {
            int sumEven = GetSumOfEvenDigit(number);
            int sumOdd = GetSumOfOddDigit(number);
            return sumEven * sumOdd;
          
        }

        private static int GetSumOfOddDigit(int number)
        {
            int odd = 0;
            while (number > 0)
            {
                if (number % 2 == 0)
                {
                    number = number / 10;
                }
                else
                {
                    odd += number % 10;
                    number = number / 10;
                }
            }
            return odd;
        }

        static int GetSumOfEvenDigit(int number)
        {
            int even = 0;
            while (number > 0)
            {
                if (number % 2 == 0)
                {
                    even += number % 10;
                    number = number / 10;
                }
                else
                {
                    number = number / 10;
                }
            }
            return even;
        }
    }
}
