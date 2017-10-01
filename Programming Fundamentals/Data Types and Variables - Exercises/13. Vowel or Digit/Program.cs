using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string vowelorDigit = Console.ReadLine();

            if (vowelorDigit == "a" || vowelorDigit == "e" || vowelorDigit == "i" || vowelorDigit == "o" ||
               vowelorDigit == "u" || vowelorDigit == "y")
            {
                Console.WriteLine("vowel");
            }
            else if (vowelorDigit == "1" || vowelorDigit == "2" || vowelorDigit == "3" || vowelorDigit == "4" ||
               vowelorDigit == "5" || vowelorDigit == "6" || vowelorDigit == "7" || vowelorDigit == "8" || vowelorDigit == "9" || vowelorDigit == "0")
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }

        }
    }
}
