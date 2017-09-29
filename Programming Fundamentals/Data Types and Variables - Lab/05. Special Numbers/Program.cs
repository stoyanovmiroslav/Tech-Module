using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= maxNumber; i++)
            {
                int number = i;
                int sum = 0;

                while (number > 0)
                {
                    int lastDigit = number % 10;
                    sum += lastDigit;
                    number = number / 10;
                }

                bool specialNumber = sum == 5 || sum == 7 || sum == 11;

                Console.WriteLine($"{i} - > {specialNumber}");
            }
        }
    }
}