﻿using System;
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

            switch(position)
            {
                case "Athlete": Console.WriteLine("Water"); break;
                case "Businessman":
                case "Businesswoman": Console.WriteLine("Coffee"); break;
                case "SoftUni Student": Console.WriteLine("Beer"); break;
                default: Console.WriteLine("Tea");  break;
            }
        }
    }
}
