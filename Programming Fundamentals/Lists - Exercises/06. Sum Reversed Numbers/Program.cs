using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main()
        {
            List<string> inputNumbers = Console.ReadLine().Split().ToList();
            List<int> reversedNumbers = new List<int>();

            for (int i = 0; i < inputNumbers.Count; i++)
            {
                string number = inputNumbers[i];
                string reversedStr = reverseTheString(number);
                int num = int.Parse(reversedStr);
                reversedNumbers.Add(num);
            }
            Console.WriteLine(reversedNumbers.Sum());
        }

        private static string reverseTheString(string number)
        {
            char[] arr = number.ToCharArray();
            char[] reversed = arr.Reverse().ToArray();
            string reversedString = string.Join("", reversed);
            return reversedString;
        }
    }
}
