using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 1; i <= count ; i+=2)
            {
                Console.WriteLine(i);
                sum += i;
                count++;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
