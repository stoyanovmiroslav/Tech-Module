using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Trophon_the_Grumpy_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                 .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            int entryPoint = int.Parse(Console.ReadLine());

            string typeOfItems = Console.ReadLine();
            string typeOfPriceRating = Console.ReadLine();

            long leftSide = LeftSide(input, entryPoint, typeOfItems, typeOfPriceRating);
            long rightSide = RightSide(input, entryPoint, typeOfItems, typeOfPriceRating);

            if (leftSide >= rightSide)
            {
                Console.WriteLine("Left - {0}", leftSide);
            }
            else
            {
                Console.WriteLine("Right - {0}", rightSide);
            }
        }

        private static long RightSide(int[] input, int entryPoint, string typeOfItems, string typeOfPriceRating)
        {
            long sum = 0;
            if (typeOfItems == "cheap")
            {
                for (int i = entryPoint + 1; i < input.Length; i++)
                {
                    if(input[i] < input[entryPoint])
                    {
                        if (typeOfPriceRating == "positive" && input[i] >= 0)
                        {
                            sum += input[i];
                        }
                        else if (typeOfPriceRating == "negative" && input[i] < 0)
                        {
                            sum += input[i];
                        }
                        else if (typeOfPriceRating == "all")
                        {
                            sum += input[i];
                        }
                    }
                }
            }
            else if (typeOfItems == "expensive")
            {
                for (int i = entryPoint + 1; i < input.Length; i++)
                {
                    if (input[i] >= input[entryPoint])
                    {
                        if (typeOfPriceRating == "positive" && input[i] >= 0)
                        {
                            sum += input[i];
                        }
                        else if (typeOfPriceRating == "negative" && input[i] < 0)
                        {
                            sum += input[i];
                        }
                        else if (typeOfPriceRating == "all")
                        {
                            sum += input[i];
                        }
                    }
                }
            }
            return sum;
        }
    

        private static long LeftSide(int[] input, int entryPoint, string typeOfItems, string typeOfPriceRating)
        {
            long sum = 0;
            if (typeOfItems == "cheap")
            {
                for (int i = entryPoint - 1; i >= 0; i--)
                {
                    if (input[i] < input[entryPoint])
                    {
                        if (typeOfPriceRating == "positive" && input[i] >= 0)
                        {
                            sum += input[i];
                        }
                        else if (typeOfPriceRating == "negative" && input[i] < 0)
                        {
                            sum += input[i];
                        }
                        else if (typeOfPriceRating == "all")
                        {
                            sum += input[i];
                        }
                    }
                }
            }
            else if (typeOfItems == "expensive")
            {
                for (int i = entryPoint-1; i >= 0; i--)
                {
                    if (input[i] >= input[entryPoint])
                    {
                        if (typeOfPriceRating == "positive" && input[i] >= 0)
                        {
                            sum += input[i];
                        }
                        else if (typeOfPriceRating == "negative" && input[i] < 0)
                        {
                            sum += input[i];
                        }
                        else if (typeOfPriceRating == "all")
                        {
                            sum += input[i];
                        }
                    }
                }
            }
            return sum;
        }
    }
}
