using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double sizeCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            if (parameter == "face")
            {
                double face = GetFaceDiagonal(sizeCube);
                Console.WriteLine("{0:F2}", face);
            }
            else if (parameter == "space")
            {
                double space = GetSpaceDiagonal(sizeCube);
                Console.WriteLine("{0:F2}", space);
            }
            else if (parameter == "volume")
            {
                double volume = GetVolume(sizeCube);
                Console.WriteLine("{0:F2}", volume);
            }
            else if(parameter == "area")
            {
                double area = GetCubeArea(sizeCube);
                Console.WriteLine("{0:F2}", area);
            }
        }

        private static double GetCubeArea(double sizeCube)
        {
            double area = 6 * (sizeCube * sizeCube);
            return area;
        }

        private static double GetVolume(double sizeCube)
        {
            double volume = sizeCube * sizeCube * sizeCube;
            return volume;
        }

        private static double GetSpaceDiagonal(double sizeCube)
        {
            double space = Math.Sqrt(3 * sizeCube * sizeCube);
            return space;
        }

        private static double GetFaceDiagonal(double sizeCube)
        {
            double face = Math.Sqrt(2 * sizeCube * sizeCube);
            return face;
        }
    }
}
