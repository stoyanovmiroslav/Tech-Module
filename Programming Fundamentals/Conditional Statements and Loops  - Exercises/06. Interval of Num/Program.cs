using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Interval_of_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int maxNumber = Math.Max(firstNumber, secondNumber);
            int minNumber = Math.Min(firstNumber, secondNumber);

                for (int i = minNumber; i <= maxNumber; i++)
                {
                    Console.WriteLine(i);
                }
           
            

        }
    }
}
