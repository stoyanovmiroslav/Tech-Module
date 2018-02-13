using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Pokemon_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            var dictOfPokemons = new Dictionary<string, List<PokemonEvolution>>();
            while ((input = Console.ReadLine()) != "wubbalubbadubdub")
            {
                if (dictOfPokemons.ContainsKey(input))
                {
                    printPokemon(input, dictOfPokemons);
                    continue;
                }
                string[] slitedInput = input.Split(new string[] { " ", "-", ">" }, StringSplitOptions.RemoveEmptyEntries);
                if (slitedInput.Length != 3)
                {
                    continue;
                }
                PokemonEvolution pokemons = new PokemonEvolution();
                pokemons.Evolution = slitedInput[1];
                pokemons.Index = int.Parse(slitedInput[2]);

                if (!dictOfPokemons.ContainsKey(slitedInput[0]))
                {
                    dictOfPokemons.Add(slitedInput[0], new List<PokemonEvolution>());


                    dictOfPokemons[slitedInput[0]].Add(pokemons);
                }
                else
                {
                    dictOfPokemons[slitedInput[0]].Add(pokemons);
                }
            }

            foreach (var item in dictOfPokemons)
            {
                Console.WriteLine("# {0}", item.Key);
                foreach (var items in item.Value.OrderByDescending(x => x.Index))
                {
                    Console.WriteLine("{0} <-> {1}", items.Evolution, items.Index);
                }
            }
        }

        private static void printPokemon(string input, Dictionary<string, List<PokemonEvolution>> dictOfPokemons)
        {
            foreach (var item in dictOfPokemons)
            {
                if (item.Key == input)
                {
                    Console.WriteLine("# {0}", item.Key);
                    foreach (var items in item.Value)
                    {
                        Console.WriteLine("{0} <-> {1}", items.Evolution, items.Index);
                    }
                }
            }
        }
    }
    class PokemonEvolution
    {
        public string Evolution { get; set; }
        public int Index { get; set; }
    }
}
