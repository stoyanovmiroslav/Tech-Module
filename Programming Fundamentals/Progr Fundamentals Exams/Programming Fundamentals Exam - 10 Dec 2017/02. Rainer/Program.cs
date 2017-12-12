using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                             .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                             .Select(int.Parse)
                             .ToList();
       
             int index = input[input.Count - 1];
             input.RemoveAt(input.Count - 1);
       
             List<int> startList = new List<int>();
          
             for (int i = 0; i < input.Count; i++)
             {
                 startList.Add(input[i]);
             }
     
            int steps = 0;
            while (true)
            {
                for (int i = 0; i < input.Count; i++)
                {
                    input[i] -= 1;
                }
                if (input[index] == 0)
                {
                    Console.WriteLine(String.Join(" ", input));
                    Console.WriteLine(steps);
                    return;
                }
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] == 0)
                    {
                        input[i] = startList[i];
                    }
                }
                
                index = int.Parse(Console.ReadLine());
                steps++;
            }
        }
    }
}
