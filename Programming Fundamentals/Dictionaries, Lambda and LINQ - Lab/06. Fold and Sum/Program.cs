using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                         .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                         .Select(int.Parse)
                         .ToArray();

            int k = arr.Length / 4;            
            int[] leftSide = arr.Take(k).Reverse().ToArray();
            int[] RightSide = arr.Skip(3 * k).Take(k).Reverse().ToArray();
            int[] body = arr.Skip(k).Take(2 * k).ToArray();
           
            int[] sides = leftSide.Concat(RightSide).ToArray();
            var sumArr = sides.Select((x, index) => x + body[index]);

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
