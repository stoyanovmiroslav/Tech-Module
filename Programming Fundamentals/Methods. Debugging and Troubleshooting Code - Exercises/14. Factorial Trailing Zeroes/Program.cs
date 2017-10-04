using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            BigInteger resultNumber = GetBigInteger(number);
            BigInteger countZeros = GetLastZeros(resultNumber);
            Console.WriteLine(countZeros);
        }

        private static BigInteger GetLastZeros(BigInteger resultNumber)
        {
            int count = 0;
            BigInteger lastNumber = 0;
            while (lastNumber == 0)
            {
                lastNumber = resultNumber % 10;
                resultNumber = resultNumber / 10;
                if (lastNumber == 0)
                {
                    count++;
                }
            }
            return count;
        }

        private static BigInteger GetBigInteger(BigInteger number)
        {
            BigInteger result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
