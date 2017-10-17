using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputKey = Console.ReadLine();
            string inputValueS = Console.ReadLine();
               

            var minerTaskDict = new Dictionary<string, long>();
           
            while (inputKey != "stop")
            {
               int inputValue = int.Parse(inputValueS);

                if (!minerTaskDict.ContainsKey(inputKey))
                {
                    minerTaskDict.Add(inputKey, 0);
                }
               
                    minerTaskDict[inputKey] += inputValue;


                inputKey = Console.ReadLine();

                if (inputKey == "stop")
                {
                    foreach (var item in minerTaskDict.Keys)
                    {
                        Console.WriteLine(item + " -> " + minerTaskDict[item]);
                    }
                    return;
                }

                inputValueS = Console.ReadLine();
            }
        }
    }
}
