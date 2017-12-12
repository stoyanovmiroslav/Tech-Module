using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.RainAir
{
    class Program
    {
        static void Main(string[] args)
        {          
            var dict = new Dictionary<string, List<int>>();
            string input = "";
            List<int> listFlights = new List<int>();
            while ((input = Console.ReadLine()) != "I believe I can fly!")
            {
                int check = input.IndexOf("=");
                if (check == -1)
                {
                    string[] inputArgs = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    string customerName = inputArgs[0];
                  
                    if (!dict.ContainsKey(customerName))
                    {
                        dict.Add(customerName, new List<int>());
                        for (int i = 1; i < inputArgs.Length; i++)
                        {
                            dict[customerName].Add(int.Parse(inputArgs[i]));
                        }
                          dict[customerName].Sort();
                    }
                    else
                    {
                        for (int i = 1; i < inputArgs.Length; i++)
                        {
                            dict[customerName].Add(int.Parse(inputArgs[i]));
                        }
                          dict[customerName].Sort();
                    }
                }
                else
                {       
                    string[] inputArgs = input.Split(new string[] { " = " }, StringSplitOptions.RemoveEmptyEntries);

                    string customerName = inputArgs[0];
                    string customerName2 = inputArgs[1];
                    if (dict.ContainsKey(customerName) && dict.ContainsKey(customerName2))
                    {
                        int[] arr = dict[customerName2].ToArray();
                        dict[customerName] = arr.ToList();
                    }
                }
            }


            foreach (var item in dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine("#{0} ::: {1}", item.Key, String.Join(", ", item.Value));
            }
        }
    }
}
