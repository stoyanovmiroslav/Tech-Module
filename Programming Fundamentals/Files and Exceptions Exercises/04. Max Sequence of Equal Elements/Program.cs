using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = File.ReadAllText("Input.txt")
                              .Split(' ')
                              .Select(int.Parse)
                              .ToList();
            int count = 1;
            int currentCount = 0;
            int currentNumber = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {

                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    if (count > currentCount)
                    {
                        currentNumber = numbers[i];
                        currentCount = count;
                    }
                }
                else
                {
                    count = 1;
                }
            }

            if (currentCount == 0)
            {
                File.AppendAllText("output.txt", "" + $"{numbers[0]} ");
            }
            else
            {
                for (int i = 0; i < currentCount; i++)
                {
                    File.AppendAllText("output.txt","" + $"{currentNumber} ");
                }
                File.AppendAllText("output.txt", Environment.NewLine);
            }
        }
    }
}
