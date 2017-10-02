using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double maxNumber = Math.Max(firstNumber, secondNumber);
            double minNumber = Math.Min(firstNumber, secondNumber);

            bool equal = false;
            if (maxNumber - minNumber <= 0.000001)
            {
                equal = true;
            }
            Console.WriteLine(equal);
        }
    }
}
