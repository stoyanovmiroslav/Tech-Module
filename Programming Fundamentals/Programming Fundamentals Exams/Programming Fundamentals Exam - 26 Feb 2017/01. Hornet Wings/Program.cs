using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingflaps = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());


            double metersTraveled = (wingflaps / 1000) * distance;
            Console.WriteLine("{0:F2} m.", metersTraveled);
            double hornetflaps = wingflaps / 100;
            double rest = (wingflaps / endurance) * 5;
            double secondsPassed = hornetflaps + rest;
            Console.WriteLine("{0} s.", secondsPassed);
        }
    }
}
