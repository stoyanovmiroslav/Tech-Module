using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            numbers.Reverse();
            numbers.RemoveAll(i => i < 0);
            if (numbers.Count > 0)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("Empty");
            }
        }
    }
}
