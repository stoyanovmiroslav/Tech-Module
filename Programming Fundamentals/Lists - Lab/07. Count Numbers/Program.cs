using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse)
                              .ToList();
            
            numbers.Sort();
            var count = 1;

            for (int j = 1; j <= numbers.Count; j++)
            {
                if (j == numbers.Count)
                {
                    Console.WriteLine("{0} -> {1}", numbers[j-1], count);
                    return;
                }
                else if (numbers[j] == numbers[j - 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", numbers[j - 1], count);
                    count = 1;
                }
            }
        }
    }
}
