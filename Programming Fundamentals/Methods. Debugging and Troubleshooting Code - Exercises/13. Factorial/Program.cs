using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            BigInteger sum = 1;
            for (int i = 1; i <= number; i++)
            {
                sum *= i;
            }
            Console.WriteLine(sum);
        }
    }
}
