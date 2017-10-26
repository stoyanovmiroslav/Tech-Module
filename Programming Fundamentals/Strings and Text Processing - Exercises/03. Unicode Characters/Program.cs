using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                int number = (int)input[i];
                string hexValue = number.ToString("x");
                Console.Write("\\u00{0}", hexValue);
            }
            Console.WriteLine();
        }
    }
}
