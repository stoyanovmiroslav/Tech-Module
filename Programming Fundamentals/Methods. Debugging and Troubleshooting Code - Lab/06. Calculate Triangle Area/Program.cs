using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstSide = double.Parse(Console.ReadLine());
            double secondSide = double.Parse(Console.ReadLine());

            double areaTriangle = CalculateTriangleArea(firstSide, secondSide);
            Console.WriteLine(areaTriangle);
        }

        static double CalculateTriangleArea(double firstSide, double secondSide)
        {
            return (firstSide* secondSide)/2;
        }
    }
}
