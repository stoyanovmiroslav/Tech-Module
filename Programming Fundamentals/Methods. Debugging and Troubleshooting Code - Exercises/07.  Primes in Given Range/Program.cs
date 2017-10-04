using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        public static void Main()
        {
            int num = 124;
            int sum = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                num = num / 10;
                sum +=lastDigit;
            }

            if (sum % 7 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
