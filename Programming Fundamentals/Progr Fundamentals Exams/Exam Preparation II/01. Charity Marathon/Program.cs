using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int maratonDays = int.Parse(Console.ReadLine());
            long numberOfRunners = long.Parse(Console.ReadLine());
            int averageNumberOfLapsEveryRunnerMakes = int.Parse(Console.ReadLine());
            long lengthTrack = long.Parse(Console.ReadLine());
            int capacityTrackPerDay = int.Parse(Console.ReadLine());

            decimal moneyDonatedPerKilometer = decimal.Parse(Console.ReadLine());
            long capacityForAllDays = capacityTrackPerDay * maratonDays;
            if (numberOfRunners > capacityForAllDays)
            {
                numberOfRunners = capacityForAllDays;
            }
            long totalMeters = numberOfRunners * averageNumberOfLapsEveryRunnerMakes * lengthTrack;
            long totalKilometers = totalMeters / 1000;
            decimal moneyRaisedForMarathon = totalKilometers * moneyDonatedPerKilometer;

           Console.WriteLine($"Money raised: {moneyRaisedForMarathon:f2}");
        }
    }
}
