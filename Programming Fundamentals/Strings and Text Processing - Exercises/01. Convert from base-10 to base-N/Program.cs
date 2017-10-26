using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

            BigInteger number = input[1];
            BigInteger baseN = input[0];

            List<BigInteger> digit = new List<BigInteger>();

            while (number != 0)
            {
                BigInteger remainder = number % baseN;
                number = number / baseN;          
                digit.Add(remainder);
            }
            digit.Reverse();
            Console.WriteLine(string.Join("", digit));
        }
    }
}
