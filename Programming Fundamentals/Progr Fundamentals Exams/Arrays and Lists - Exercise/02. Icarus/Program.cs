using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                                 .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();
            int index = int.Parse(Console.ReadLine());
            string command = "";
            int damage = 1;
            while ((command = Console.ReadLine()) != "Supernova")
            {
                string[] arrCommand = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                int steps = int.Parse(arrCommand[1]);

                if (arrCommand[0] == "left" && steps != 0)
                {
                    for (int i = 1; i <= steps; i++)
                    {
                        if (index <= 0)
                        {
                            damage++;
                            index = input.Length;

                        }
                        input[index - 1] = input[index - 1] - damage;
                        index--;

                    }
                }
                else if (arrCommand[0] == "right" && steps != 0)
                {
                    for (int i = 1; i <= steps; i++)
                    {
                        if (index >= input.Length - 1 ) 
                        {
                            damage++;
                            index = -1;

                        }
                        input[index + 1] = input[index + 1] - damage;
                        index++;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
