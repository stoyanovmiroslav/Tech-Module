using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int constantNumber = int.Parse(Console.ReadLine());
            int varibleNumber = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{constantNumber} X {varibleNumber} = {constantNumber * varibleNumber}");
                varibleNumber++;
            } while (varibleNumber <= 10);



        }
    }
}
