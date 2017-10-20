using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();

            double distance = CalDistance(p1, p2);
            Console.WriteLine("{0:F3}", distance);
        }

        private static double CalDistance(Point p1, Point p2)
        {
            int x = p2.X - p1.X;
            int y = p2.Y - p1.Y;
            return Math.Sqrt(x * x + y * y);
        }

        private static Point ReadPoint()
        {
            int[] numbers = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();
            Point p = new Point();
            p.X = numbers[0];
            p.Y = numbers[1];
            return p;
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}