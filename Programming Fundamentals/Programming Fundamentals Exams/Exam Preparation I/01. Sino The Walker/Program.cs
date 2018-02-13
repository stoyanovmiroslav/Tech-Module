using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime leavesTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", null);
            ulong steps = ulong.Parse(Console.ReadLine());
            ulong seconds = ulong.Parse(Console.ReadLine());
            ulong secondsForAllSteps = (steps * seconds) % 86400;

            string result = leavesTime.AddSeconds(secondsForAllSteps).ToString("HH:mm:ss");
            Console.Write("Time Arrival: {0}", result);
        }
    }
}
