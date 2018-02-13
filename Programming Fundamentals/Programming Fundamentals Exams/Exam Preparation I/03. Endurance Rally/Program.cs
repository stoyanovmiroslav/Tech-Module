using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] drivers = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            double[] zones = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            double[] checkpodoubles = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < drivers.Length; i++)
            {
                char[] arr = drivers[i].ToCharArray();
                double fuel = arr[0];
                for (int j = 0; j < zones.Length; j++)
                {
                    if (checkpodoubles.Contains(j))
                    {
                        fuel += zones[j];
                    }
                    else
                    {
                        fuel -= zones[j];
                    }

                    if (fuel <= 0)
                    {
                        Console.WriteLine("{0} - reached {1}", drivers[i], j);
                        break;
                    }
                    if (j == zones.Length-1)
                    {
                        Console.WriteLine("{0} - fuel left {1:F2}", drivers[i], fuel);
                    }
                }
            }
        }
    }
}
