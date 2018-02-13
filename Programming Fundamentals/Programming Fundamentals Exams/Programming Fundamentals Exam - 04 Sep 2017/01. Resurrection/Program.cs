using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                long totalLenghtOfTheBody = long.Parse(Console.ReadLine());
                decimal totalWidthOfTheBody = decimal.Parse(Console.ReadLine());
                long OneWingLenght = long.Parse(Console.ReadLine());

                decimal totalYears = totalLenghtOfTheBody * totalLenghtOfTheBody * (totalWidthOfTheBody + 2 * OneWingLenght);

                Console.WriteLine(totalYears);
            }
        }
    }
}
