using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string[] arrTwo = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int leftCount = FindMaxCommonItems(arrOne, arrTwo);
            Array.Reverse(arrOne); // secondArr = secondArr.Reverse90.ToArray();
            Array.Reverse(arrTwo);

            int rightCount = FindMaxCommonItems(arrOne, arrTwo);
            Console.WriteLine($"{Math.Max(leftCount, rightCount)}");
        }
        public static int FindMaxCommonItems(string[] arrOne, string[] arrTwo)
        {
            int count = 0;
            int lenght = Math.Min(arrOne.Length, arrTwo.Length);

            for (int i = 0; i < lenght; i++)
            {
                if (arrOne[i] == arrTwo[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }
    }
}

