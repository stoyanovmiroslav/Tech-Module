using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_Exchangeable_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            char[] wordOne = input[0].ToCharArray().Distinct().ToArray();
            char[] wordTwo = input[1].ToCharArray().Distinct().ToArray();

            if (wordOne.Length == wordTwo.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
