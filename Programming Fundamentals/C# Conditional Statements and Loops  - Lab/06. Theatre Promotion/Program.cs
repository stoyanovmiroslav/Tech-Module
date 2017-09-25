using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var price = 0;

            if (age >= 0 && age <= 18)
            {
                if (name == "Weekday") price = 12;
                else if (name == "Weekend") price = 15;
                else if (name == "Holiday") price = 5;
            }
            else if (age > 18 && age <= 64)
            {
                if (name == "Weekday") price = 18;
                else if (name == "Weekend") price = 20;
                else if (name == "Holiday") price = 12;
            }
            else if (age > 64 && age <= 122)
            {
                if (name == "Weekday") price = 12;
                else if (name == "Weekend") price = 15;
                else if (name == "Holiday") price = 10;
            }
            else
            {
                Console.WriteLine("Error!");
                return;
            }

            Console.WriteLine($"{price}$");

        }
    }
}
