using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .ToLower()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            var legendaryFarming = new Dictionary<string, int>();
            var junk = new Dictionary<string, int>();

            while (true)
            {
                for (int i = 0; i < input.Length; i += 2)
                {
                    int marks = int.Parse(input[i]);
                    string material = input[i + 1];
                    
                    if (material == "fragments" || material == "shards" || material == "motes")
                    {
                        if (!legendaryFarming.ContainsKey(material))
                        {
                            legendaryFarming.Add(material, 0);
                            if (material != "fragments")
                            legendaryFarming.Add("fragments", 0);
                            if (material != "shards")
                                legendaryFarming.Add("shards", 0);
                            if (material != "motes")
                                legendaryFarming.Add("motes", 0);

                            legendaryFarming[material] = marks;
                        }
                        else
                        {
                            legendaryFarming[material] += marks;
                        }

                        if (legendaryFarming[material] >= 250)
                        {
                            legendaryFarming[material] = legendaryFarming[material] - 250;
                            string winner = "";
                            if (material == "shards") winner = "Shadowmourne";
                            else if (material == "fragments") winner = "Valanyr";
                            else if (material == "motes") winner = "Dragonwrath";

                            Console.WriteLine("{0} obtained!", winner);
                            foreach (var item in legendaryFarming.OrderByDescending(x => x.Value ).ThenBy(y => y.Key))
                            {
                                Console.WriteLine("{0}: {1}", item.Key, item.Value);
                            }

                            foreach (var junkMaterial in junk.OrderBy(x => x.Key))
                            {
                                Console.WriteLine("{0}: {1}", junkMaterial.Key, junkMaterial.Value);
                            }
                            return;
                        }
                    }
                    else //junk entry
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, 0);
                            junk[material] = marks;
                        }
                        else
                        {
                            junk[material] += marks;
                        }
                    }
                }
                input = Console.ReadLine()
               .ToLower()
               .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
