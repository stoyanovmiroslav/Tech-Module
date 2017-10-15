﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> number = Console.ReadLine()
                         .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                         .Select(double.Parse)
                         .ToList();
            number.Sort();
            Console.WriteLine(String.Join(" <= ", number));

        }
    }
}
