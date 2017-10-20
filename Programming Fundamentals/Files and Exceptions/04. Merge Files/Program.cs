using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = File.ReadAllText("FileOne.txt")
                        .Split(new string[] { "\r", "\n", "-", ",", "?", ".", "\'", " ", "!", ":", " " }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

            int[] input2 = File.ReadAllText("FileTwo.txt")
                        .Split(new string[] { "\r", "\n", "-", ",", "?", ".", "\'", " ", "!", ":", " " }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

            List<int> allNumbers = new List<int>();
            allNumbers.AddRange(input1);
            allNumbers.AddRange(input2);
            var result = allNumbers.OrderBy(x => x).ToList();

            foreach (var item in result)
            {
                File.AppendAllText("output.txt", item + Environment.NewLine);
            }
          
        }
    }
}
