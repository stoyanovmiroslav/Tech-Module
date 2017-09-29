using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RefSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int specNumber = i;
                int sum = 0;
                while (i > 0)
                {
                 sum += specNumber % 10;
                    specNumber = specNumber / 10;
                }
                bool exception = false;
                exception = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{specNumber} -> {exception}");
            }

        }
    }
}
