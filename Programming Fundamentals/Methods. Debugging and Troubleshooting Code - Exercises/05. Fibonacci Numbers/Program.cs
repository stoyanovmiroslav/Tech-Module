using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            ulong fibonacciNumber = GetFibonacciNumber(number);
            Console.WriteLine(fibonacciNumber);
        }

        static ulong GetFibonacciNumber(int number)
        {
            uint a = 0;
            uint b = 1;
            uint c = 1;

            for (uint i = 0; i < number; i++)
            {
                c = b + a;
                a = b;
                b = c;
            }
            return c;
        }
    }
}
