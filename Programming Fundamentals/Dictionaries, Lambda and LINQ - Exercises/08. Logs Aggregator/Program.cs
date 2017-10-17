using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var logsAggregator = new Dictionary<string, Dictionary<string, int>>();
            int inputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = input[1];
                string ip = input[0];
                int duration = int.Parse(input[2]);

                if (!logsAggregator.ContainsKey(name))
                {
                    logsAggregator.Add(name, new Dictionary<string, int>());
                    logsAggregator[name].Add(ip, 0);
                }
                else if(!logsAggregator[name].ContainsKey(ip))
                {
                    logsAggregator[name].Add(ip, 0);
                }

                logsAggregator[name][ip] += duration;


            }
            foreach (var names in logsAggregator.OrderBy(x => x.Key))
            {
                Console.Write("{0}: {1} ", names.Key, names.Value.Values.Sum());
                Console.Write("[");
                int counter = 0;
                foreach (var ipAddress in names.Value.OrderBy(x => x.Key))
                {
                    Console.Write("{0}", ipAddress.Key);
                    counter++;
                    if (names.Value.Count != counter)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("]");
            }
        }
    }
}
