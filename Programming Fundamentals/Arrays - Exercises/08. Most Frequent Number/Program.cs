using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int count = 0;
            int currentCount = 0;
            int maxNumber = 0;

            for (int i = 0; i < numbers.Length ; i++)
            {
                count = 0;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;

                        if (count > currentCount)
                        {
                            currentCount = count;
                            maxNumber = numbers[i];
                        }
                    }
                }
            }

            if (currentCount > 0)
            {
                Console.WriteLine(maxNumber);
            }
            else
            {
                Console.WriteLine(numbers[0]);
            }
        }
    }
}
