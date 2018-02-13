using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> powerPokemons = Console.ReadLine()
                                     .Split(' ')
                                     .Select(int.Parse)
                                     .ToList();
            int index = int.Parse(Console.ReadLine());

            List<int> removedNumbers = new List<int>();

            while (powerPokemons.Count > 0)
            {
                int numer = 0;
                if (index < 0)
                {
                    index = 0;
                    numer = powerPokemons[index];
                    powerPokemons[0] =  powerPokemons[powerPokemons.Count - 1];
                }
                else if (index > powerPokemons.Count - 1)
                {
                    index = powerPokemons.Count - 1;
                    numer = powerPokemons[index];
                    powerPokemons[powerPokemons.Count - 1] = powerPokemons[0];
                }
                else
                {
                    numer = powerPokemons[index];
                    powerPokemons.RemoveAt(index);
                }
                
                for (int i = 0; i < powerPokemons.Count; i++)
                {
                    if (powerPokemons[i] > numer)
                    {
                        powerPokemons[i] -= numer;
                    }
                    else
                    {
                        powerPokemons[i] += numer;
                    }
                }
                removedNumbers.Add(numer);
                if (powerPokemons.Count == 0)
                {
                    break;
                }
                index = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(removedNumbers.Sum());
        }
    }
}
