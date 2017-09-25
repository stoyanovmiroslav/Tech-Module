using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currenthealth = int.Parse(Console.ReadLine());
            int maximunhealth = int.Parse(Console.ReadLine());
            int currentenergy = int.Parse(Console.ReadLine());
            int maximunenergy = int.Parse(Console.ReadLine());

            var point = maximunenergy - currentenergy;
            var line = maximunhealth - currenthealth;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |{0}{1}|",
                     new string('|', currenthealth ),
                     new string('.', line ));

            Console.WriteLine("Energy:|{0}{1}|",
                     new string('|', currentenergy),
                     new string('.', point));
        }
    }
}
