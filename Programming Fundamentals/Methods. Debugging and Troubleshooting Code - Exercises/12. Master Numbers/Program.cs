using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                bool isPalindrome = IsPalindrome(i);
                bool sumOfDigits = SumOfDigits(i);
                bool containsEvenDigit = ContainsEvenDigit(i);

                if (isPalindrome && sumOfDigits && containsEvenDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainsEvenDigit(int num)
        {
            while (num > 0)
            {
                int lastDigit = num % 10;
                num = num / 10;
                if (lastDigit % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                num = num / 10;
                sum += lastDigit;
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsPalindrome(int num)
        {
            string number = num.ToString();
            for (int i = 0; i < number.Length / 2; i++)
                {
                    char firstLatter = number[i];
                    char lastLatter = number[number.Length - 1 - i];


                if (firstLatter == lastLatter)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
