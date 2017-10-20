using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstInput = Console.ReadLine()
                              .Split(' ')
                              .Select(int.Parse)
                              .ToArray();
            int[] secondInput = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();

            Point p1 = ReadPoint(firstInput[0], firstInput[1]);
            Point p2 = ReadPoint(secondInput[0], secondInput[1]);
            Point p1Radius = ReadRadius(firstInput[2]);
            Point p2Radius = ReadRadius(firstInput[2]);

            bool intersect = Intersect(p1, p1Radius, p2, p2Radius);

            if (intersect)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

        }
        private static Point ReadPoint(int x, int y)
        {
            Point p = new Point { X = x, Y = y };
            return p;
        }
        private static Point ReadRadius(int radiusIn)
        {
            Point r = new Point { Radius = radiusIn };
            return r;
        }

        static double CalcDistance(Point p1, Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
        private static bool Intersect(Point p1, Point p1Radius, Point p2, Point p2Radius)
        {
            double distance = CalcDistance(p1, p2);
            double allRadius = p1Radius.Radius + p2Radius.Radius;
            if (distance > allRadius)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }
    }    
}
