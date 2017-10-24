using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _18.Sequence_of_Commands
{
    class Program
    {
        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "stop")
            {
                int[] args = new int[2];
                if (command[0] == "add" || command[0] == "subtract" || command[0] == "multiply")
                {
                    args[0] = int.Parse(command[1]);
                    args[1] = int.Parse(command[2]);

                    PerformAction(array, command[0], args);
                }
                else
                {
                    PerformAction(array, command[0], args);
                }

                PrintArray(array);
                Console.WriteLine();
                command = Console.ReadLine().Split(' ');
            }
        }

        static void PerformAction(long[] array, string action, int[] args)
        {
            int index = args[0] - 1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[index] *= value;
                    break;
                case "add":
                    array[index] += value;
                    break;
                case "subtract":
                    array[index] -= value;
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
            long rem = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = rem;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long rem = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = rem;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
