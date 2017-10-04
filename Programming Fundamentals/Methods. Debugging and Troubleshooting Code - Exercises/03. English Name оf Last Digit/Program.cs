using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_оf_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string textOfNumbers = Console.ReadLine();
            string lastSymbol = GetLastDigit(textOfNumbers);
            Console.WriteLine(lastSymbol);
        }

        static string GetLastDigit(string textOfNumbers)
        {
            string lastSymbol = textOfNumbers.Substring(textOfNumbers.Length - 1);
            string nameNumber = "";

            switch(lastSymbol)
            {
                case "1" : nameNumber = "one"; break;
                case "2" : nameNumber = "two"; break;
                case "3" : nameNumber = "three"; break;
                case "4" : nameNumber = "four"; break;
                case "5" : nameNumber = "five"; break;
                case "6" : nameNumber = "six"; break;
                case "7" : nameNumber = "seven"; break;
                case "8" : nameNumber = "eight"; break;
                case "9" : nameNumber = "nine"; break;
                case "0": nameNumber = "zero"; break;
            }         
            return nameNumber;
        }
    }
}
