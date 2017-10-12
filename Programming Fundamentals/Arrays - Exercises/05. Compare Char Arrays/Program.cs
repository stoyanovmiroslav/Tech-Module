using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int arrMin = Math.Min(arr1.Length, arr2.Length);
            bool arrOne = false;
            bool arrTwo = false;

            for (int i = 0; i < arrMin; i++)
            {
                if (arr1[i] < arr2[i])
                {
                    arrOne = true;
                    break;
                }
                else if (arr1[i] > arr2[i])
                {
                    arrTwo = true;
                    break;
                }
                

            }
            if (arrOne || arrMin == arr1.Length)
            {
                Console.WriteLine(String.Join("", arr1));
                Console.WriteLine(String.Join("", arr2));
            }
            else if(arrTwo || arrMin == arr2.Length)
            {
                Console.WriteLine(String.Join("", arr2));
                Console.WriteLine(String.Join("", arr2));
            }

        }
    }
}
