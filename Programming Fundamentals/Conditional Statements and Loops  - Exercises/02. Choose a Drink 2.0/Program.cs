using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string position = Console.ReadLine();
            int value = int.Parse(Console.ReadLine());
            var price = 0.0;


            switch (position)
            {
                case "Athlete": price = 0.70; break;
                case "Businessman":
                case "Businesswoman": price = 1.00; break;
                case "SoftUni Student": price = 1.70; break;
                default: price = 1.20; break;
            }
            price = price * value;
            Console.WriteLine($"The {position} has to pay {price:F2}.");
        }
    }
}
