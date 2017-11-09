using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine()
                                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(long.Parse)
                                .ToList();
            List<long> hornets = Console.ReadLine()
                                      .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                      .Select(long.Parse)
                                      .ToList();


            long sumOfHornets = hornets.Sum();
            int count = beehives.Count;
            StringBuilder sbBeehives = new StringBuilder();
          
            for (int i = 0; i < count; i++)
            {
                if (sumOfHornets > beehives[0])
                {
                    beehives.RemoveAt(0);
                }
                else if (sumOfHornets <= beehives[0])
                {
                    if (hornets.Count > 0)
                    {
                        hornets.RemoveAt(0);
                        beehives[0] = beehives[0] - sumOfHornets;
                    }
                    if (beehives[0] > 0)
                    {
                        sbBeehives.Append($"{beehives[0]} ");
                    }

                    beehives.RemoveAt(0);
                    sumOfHornets = hornets.Sum();
                }
            }

            if (sbBeehives.Length > 0)
            {
                Console.WriteLine(sbBeehives);
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
