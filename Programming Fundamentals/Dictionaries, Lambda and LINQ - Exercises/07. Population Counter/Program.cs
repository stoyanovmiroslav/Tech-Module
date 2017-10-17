using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new Dictionary<string, Dictionary<string, long>>();
            string[] cityCountryPopulation = Console.ReadLine().Split('|');

            while (cityCountryPopulation[0] != "report")
            {
                string city = cityCountryPopulation[0];
                string country = cityCountryPopulation[1];
                long polpulation = long.Parse(cityCountryPopulation[2]);

                if (!input.ContainsKey(country))
                {
                    input.Add(country, new Dictionary<string, long>());
                    input[country].Add(city, 0);
                }
                else
                {
                    input[country].Add(city, 0);
                }

                input[country][city] += polpulation;



                cityCountryPopulation = Console.ReadLine().Split('|');
            }

            foreach (var country in input.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine("{0} (total population: {1})", country.Key, country.Value.Values.Sum());

                foreach (var city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
                }
            }
        }
    }
}
