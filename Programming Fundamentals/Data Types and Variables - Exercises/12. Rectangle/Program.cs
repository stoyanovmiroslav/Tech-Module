﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double rectanglePerimeter = (width * 2) + (height * 2);
            double rectangleArea = width * height;
            double rectangleDiagonale = Math.Sqrt((width * width) + (height * height));


            Console.WriteLine(rectanglePerimeter);
            Console.WriteLine(rectangleArea);
            Console.WriteLine(rectangleDiagonale); 
        }
    }
}
