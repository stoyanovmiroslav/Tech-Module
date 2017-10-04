using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            if (figureType == "triangle")
            {
                double triangleArea = GetTriangleArea();
                Console.WriteLine($"{triangleArea:F2}");
            }
            else if (figureType == "square")
            {
                double squareArea = GetSquareArea();
                Console.WriteLine($"{squareArea:F2}");
            }
            else if (figureType == "rectangle")
            {
                double rectangleArea = GetRectangleArea();
                Console.WriteLine($"{rectangleArea:F2}");
            }
            else if (figureType == "circle")
            {
                double circleArea = GetCircleArea();
                Console.WriteLine($"{circleArea:F2}");
            }
        }

        private static double GetCircleArea()
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            return area;
        }

        private static double GetRectangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = side * height;
            return area;
        }

        private static double GetSquareArea()
        {
            double side = double.Parse(Console.ReadLine());
            double area = side * side;
            return area;
        }

        private static double GetTriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = (side * height)/2;
            return area;

        }
    }
}
