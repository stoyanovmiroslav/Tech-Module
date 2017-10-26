using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();

            if (firstNumber.Length < secondNumber.Length)
            {
              firstNumber = firstNumber.PadLeft(secondNumber.Length, '0');
            }
            else if(firstNumber.Length > secondNumber.Length)
            {
               secondNumber = secondNumber.PadLeft(firstNumber.Length, '0');
            }

            int[] secondNumsToInt = secondNumber.ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            int[] firstdNumsToInt = firstNumber.ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();

            List<int> resultNumber = new List<int>();
            int rem = 0;
            for (int i = secondNumsToInt.Length - 1; i >= 0; i--)
            {
                int sum = secondNumsToInt[i] + firstdNumsToInt[i] + rem;
                if (sum > 9)
                {
                    rem = sum / 10;
                    sum = sum % 10;
                }
                else
                {
                    rem = 0;
                }
                resultNumber.Add(sum);
            }
            if (rem != 0)
            {
                resultNumber.Add(rem);
            }

            resultNumber.Reverse();
            while (resultNumber[0] == 0)
            {
               resultNumber.RemoveRange(0, 1);
            }

            foreach (var item in resultNumber)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
