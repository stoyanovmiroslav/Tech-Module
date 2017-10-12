using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool[] arr = new bool[number + 1];

            for (int i = 0; i <= number; i++)
            {
                arr[i] = true;
            }
            arr[0] = arr[1] = false;

            for (int i = 0; i < Math.Sqrt(number); i++)
            {
                if (arr[i])
                {
                    for (int j = i * i ; j < arr.Length; j+=i)
                    {
                        arr[j] = false;
                    }
                } 
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i])
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
