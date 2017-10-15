using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                              .Split(' ')
                              .Select(int.Parse)
                              .ToList();
            int[] arrTreeNumbers = Console.ReadLine()
                               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            int deleteNumbers = arrTreeNumbers[1];
            int searchNumber = arrTreeNumbers[2];
           
            List<int> takeNumbers = new List<int>(numbers.Take(arrTreeNumbers[0]));

            for (int i = 0; i < deleteNumbers; i++)
            {
                takeNumbers.RemoveAt(0);
            }
            if (takeNumbers.Contains(searchNumber))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
