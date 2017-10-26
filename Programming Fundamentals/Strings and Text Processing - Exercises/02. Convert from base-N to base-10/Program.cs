using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Trim().Split(' ');
            int baseN = int.Parse(input[0]);
            char[] numberOfChars = input[1].ToCharArray();

            BigInteger result = new BigInteger(0);
            int n = 0;
            for (int i = numberOfChars.Length - 1; i >= 0; i--)
            {
             
                BigInteger number = new BigInteger(char.GetNumericValue(numberOfChars[n++]));

                BigInteger sum = BigInteger.Multiply(number, BigInteger.Pow(new BigInteger(baseN), i));

                result += sum;
            }
            Console.WriteLine(result.ToString());
        }
    }
}
