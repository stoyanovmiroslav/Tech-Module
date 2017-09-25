using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = int.Parse(Console.ReadLine());
            int secondnumber = int.Parse(Console.ReadLine());
            int thirtnumber = int.Parse(Console.ReadLine());
            int fourthnumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstnumber:D4} {secondnumber:D4} {thirtnumber:D4} {fourthnumber:D4}");

        }
    }
}
