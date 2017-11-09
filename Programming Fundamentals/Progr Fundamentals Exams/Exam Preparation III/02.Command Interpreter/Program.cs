using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                            .ToList();

            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] splitCommand = command.Split(' ');

                if (splitCommand[0] == "rollLeft")
                {
                    int count = int.Parse(splitCommand[1]);
                    if (count >= 0)
                    {
                        rollLeft(numbers, count);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (splitCommand[0] == "rollRight")
                {
                    int count = int.Parse(splitCommand[1]);
                    if (count >= 0)
                    {
                        rollRight(numbers, count);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (splitCommand[0] == "reverse")
                {
                    int count = int.Parse(splitCommand[4]);
                    int start = int.Parse(splitCommand[2]);
                    if (start >= 0 && start < numbers.Count && count >=0 && start + count <= numbers.Count)
                    {                    
                        revers(numbers, start, count);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (splitCommand[0] == "sort")
                {
                    int count = int.Parse(splitCommand[4]);
                    int start = int.Parse(splitCommand[2]);
                    if (start >= 0 && start < numbers.Count && count >= 0 && start + count <= numbers.Count)
                    {
                        sort(numbers, start, count);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
            }
            Console.WriteLine("[{0}]", String.Join(", ", numbers));
        }

        private static void rollRight(List<string> numbers, int count)
        {
            count = count % numbers.Count;

            for (int i = 0; i < count; i++)
            {
                string takeNumber = numbers[numbers.Count - 1];
                numbers.Insert(0, takeNumber);
                numbers.RemoveAt(numbers.Count - 1);
            }
        }

        private static void rollLeft(List<string> numbers, int count)
        {
            count = count % numbers.Count;
            for (int i = 0; i < count; i++)
            {
                string takeNumber = numbers[0];
                numbers.Add(takeNumber);
                numbers.RemoveAt(0);
            }
        }

        private static void sort(List<string> numbers, int start, int count)
        {
            List<string> sortNumbers = new List<string>();
            sortNumbers = numbers.Skip(start).Take(count).OrderBy(x => x).ToList();
            numbers.RemoveRange(start, count);
            numbers.InsertRange(start, sortNumbers);
        }

        private static void revers(List<string> numbers, int start, int count)
        {
            List<string> reversedNumbers = new List<string>();
            reversedNumbers = numbers.Skip(start).Take(count).Reverse().ToList();
            numbers.RemoveRange(start, count);
            numbers.InsertRange(start, reversedNumbers);
        }
    }
}
