using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int maxNumber = GetMaxNunmber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(maxNumber);
        }

        private static int GetMaxNunmber(int firstNumber, int secondNumber, int thirdNumber)
        {
            int maxNumber = Math.Max(firstNumber, secondNumber);
            maxNumber = Math.Max(maxNumber, thirdNumber);
            return maxNumber;
        }
    }
}
