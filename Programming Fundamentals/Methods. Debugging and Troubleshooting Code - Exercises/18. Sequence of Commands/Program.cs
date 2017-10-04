﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Sequence_of_Commands
{
    class Program
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            // string command = Console.ReadLine();
            string line = "";
            while (!line.Equals("over"))
            {
                line = Console.ReadLine().Trim();
                int[] args = new int[2];
                
              string[] commanded = line.Split(' ');
              //  long result = 0;
              //  switch (codeArgs[0])

                if (commanded[0].Equals("add") ||
                    commanded[0].Equals("substract") ||
                    commanded[0].Equals("multiply"))
                {
                    string[] stringParams = line.Split(ArgumentsDelimiter);
                    args[0] = int.Parse(stringParams[0]);
                    args[1] = int.Parse(stringParams[1]);

                    PerformAction(array, line, args);
                }

                PerformAction(array, line, args);

                PrintArray(array);
                Console.WriteLine('\n');

                line = Console.ReadLine();
            }
        }

        static void PerformAction(long[] arr, string action, int[] args)
        {
            long[] array = arr.Clone() as long[];
            int pos = args[0];
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "subtract":
                    array[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
        }

        private static void ArrayShiftLeft(long[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }
    }
}
