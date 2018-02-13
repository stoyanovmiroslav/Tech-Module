using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal density = decimal.Parse(Console.ReadLine());

            decimal sumOfAllRegionalCoefficient = 0M;
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                decimal raindropsCount = decimal.Parse(input[0]);
                decimal squareMeters = decimal.Parse(input[1]);

                decimal regionalCoefficient = raindropsCount / squareMeters;

                sumOfAllRegionalCoefficient += regionalCoefficient;
            }

            decimal result = 0M;
            try
            {
               result = sumOfAllRegionalCoefficient / density;
            }
            catch (Exception)
            {
                result = sumOfAllRegionalCoefficient;
            }
            Console.WriteLine("{0:f3}", result);
        }
    }
}
