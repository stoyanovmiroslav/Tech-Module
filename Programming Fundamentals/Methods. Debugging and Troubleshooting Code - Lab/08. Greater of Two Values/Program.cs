using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipe = Console.ReadLine();
            if (tipe == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int maxNumber = GetMax(firstNumber, secondNumber);
                Console.WriteLine(maxNumber);
            }
            else if (tipe == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                int maxChar = GetMaxChar(first, second);
                Console.WriteLine("{0}", (char)maxChar);

            }
            else if (tipe == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string maxString = GetMaxString(first, second);
                Console.WriteLine(maxString);
            }
        }

        static string GetMaxString(string first, string second)
        {
            //if (first.Length > second.Length)
            if(first.CompareTo(second) >=0)
            {
                return first;
            }
            else
            {
                return second;
            }
             
        }

        static int GetMaxChar(char first, char second)
        {
            int maxChar = Math.Max(first, second);
            return maxChar;
        }

        static int GetMax(int firstNumber, int secondNumber)
        {
            int maxNumber = Math.Max(firstNumber, secondNumber);
            int minNumber = Math.Min(firstNumber, secondNumber);
            return maxNumber;
        }
    }
}
