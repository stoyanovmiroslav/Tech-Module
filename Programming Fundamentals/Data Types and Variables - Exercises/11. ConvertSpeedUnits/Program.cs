﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float allSeconds = seconds + (minutes * 60) + (hours * 60 * 60);

            float metersPerSecond = distanceMeters / allSeconds;
            float kilometersPerHours = (distanceMeters / 1000) / (allSeconds / 3600);
            float milesPerHour = (distanceMeters / 1609) / (allSeconds / 3600);
            
            Console.WriteLine("{0}",metersPerSecond);
            Console.WriteLine("{0}", kilometersPerHours);
            Console.WriteLine("{0}" , milesPerHour);
        }
    }
}
