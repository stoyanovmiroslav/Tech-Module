using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictRoliTheCoder = new Dictionary<string, Dictionary<string, List<string>>>();
            string input = "";

            while ((input = Console.ReadLine()) != "Time for Code")
            {
               RoliTheCoderCheck(dictRoliTheCoder, input);
            }
               PrintOutput(dictRoliTheCoder);
        }

        private static void RoliTheCoderCheck(Dictionary<string, Dictionary<string, List<string>>> dictRoliTheCoder, string input)
        {
            string[] splitInput = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            if (splitInput[1][0] != '#')
            {
                return;
            }
            else
            {
                splitInput[1] = splitInput[1].Substring(1, splitInput[1].Length - 1);
            }
            if (!dictRoliTheCoder.ContainsKey(splitInput[0]))
            {
                dictRoliTheCoder.Add(splitInput[0], new Dictionary<string, List<string>>());
                dictRoliTheCoder[splitInput[0]].Add(splitInput[1], new List<string>());
            }
            if (dictRoliTheCoder[splitInput[0]].ContainsKey(splitInput[1]))
            {
                for (int i = 2; i < splitInput.Length; i++)
                {
                    string check = splitInput[i].Substring(0, 1);
                    if (check == "@")
                    {
                        dictRoliTheCoder[splitInput[0]][splitInput[1]].Add(splitInput[i]);
                        dictRoliTheCoder[splitInput[0]][splitInput[1]]
                            = dictRoliTheCoder[splitInput[0]][splitInput[1]].Distinct().ToList();
                    }
                }
            }
        }

        private static void PrintOutput(Dictionary<string, Dictionary<string, List<string>>> dictRoliTheCoder)
        {
            var output = new Dictionary<string, List<string>>();

            foreach (var item in dictRoliTheCoder)
            {
                foreach (var items in item.Value)
                {
                    output.Add(items.Key + " - " + items.Value.Count, items.Value);
                }
            }
            foreach (var item in output.OrderByDescending(x => x.Value.Count).ThenBy(y => y.Key))
            {
                Console.WriteLine("{0}", item.Key);
                if (item.Value.Count > 0)
                {
                    Console.WriteLine("{0} ", String.Join("\n", item.Value.OrderBy(x => x)));
                }
            }
        }
    }
}
