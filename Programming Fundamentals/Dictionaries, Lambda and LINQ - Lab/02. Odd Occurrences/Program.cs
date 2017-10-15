using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .ToLower()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var count = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (count.ContainsKey(word))
                {
                    count[word]++;
                }
                else
                {
                    count[word] = 1;
                }
            }
            var results = new List<string>();

            foreach (var pair in count)
            {
                if (pair.Value % 2 != 0)
                {
                    results.Add(pair.Key);
                }
            }        
            Console.WriteLine(string.Join(", ", results));
        }
    }
}
