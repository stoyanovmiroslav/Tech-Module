using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                                  .Split(' ')
                                  .Select(int.Parse)
                                  .ToList();
           
            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                List<int> newList = new List<int>();
                string[] splitInput = input.Split(' ');
                string command = splitInput[0];

                if (command == "exchange")
                {
                    exchange(splitInput, list, newList);
                }
                else if (command == "max")
                {
                    Max(splitInput, list, newList);
                }
                else if (command == "min")
                {
                    Min(splitInput, list, newList);
                }
                else if (command == "first")
                {
                    First(splitInput, list, newList);
                }
                else if (command == "last")
                {
                    Last(splitInput, list, newList);
                }
            }
            Console.WriteLine("[{0}]", String.Join(", ", list));
        }

        private static void Last(string[] splitInput, List<int> list, List<int> newList)
        {
            int count = int.Parse(splitInput[1]);
            string oddOrEven = splitInput[2];

            if (oddOrEven == "odd" && count <= list.Count)
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    if (list[i] % 2 != 0 && count > newList.Count)
                    {
                        newList.Add(list[i]);
                    }

                }
                newList.Reverse();
                Console.WriteLine("[{0}]", String.Join(", ", newList));
            }
            else if (oddOrEven == "even" && count <= list.Count)
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    if (list[i] % 2 == 0 && count > newList.Count)
                    {
                        newList.Add(list[i]);
                    }

                }
                newList.Reverse();
                Console.WriteLine("[{0}]", String.Join(", ", newList));
            }
            else
            {
                Console.WriteLine("Invalid count");
            }
        }

        private static void First(string[] splitInput, List<int> list, List<int> newList)
        {
            int count = int.Parse(splitInput[1]);
            string oddOrEven = splitInput[2];

            if (oddOrEven == "odd" && count <= list.Count)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 != 0 && count > newList.Count)
                    {
                        newList.Add(list[i]);
                    }

                }
                Console.WriteLine("[{0}]", String.Join(", ", newList));
            }
            else if (oddOrEven == "even" && count <= list.Count)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0 && count > newList.Count)
                    {
                        newList.Add(list[i]);
                    }

                }
                Console.WriteLine("[{0}]" , String.Join(", ", newList));
            }
            else
            {
                Console.WriteLine("Invalid count");
            }
        }

        private static void Min(string[] splitInput, List<int> list, List<int> newList)
        {
            string oddOrEven = splitInput[1];
            if (oddOrEven == "odd")
            {
                int index = -1;
                int number = int.MaxValue;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 != 0 && list[i] <= number)
                    {
                        number = list[i];
                        index = i;
                    }
                }
                if (index >= 0)
                {
                    Console.WriteLine(index);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else if (oddOrEven == "even")
            {
                int index = -1;
                int number = int.MaxValue;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0 && list[i] <= number)
                    {
                        number = list[i];
                        index = i;
                    }
                }
                if (index >= 0)
                {
                    Console.WriteLine(index);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        private static void Max(string[] splitInput, List<int> list, List<int> newList)
        {
            string oddOrEven = splitInput[1];
            if (oddOrEven == "odd")
            {
                int index = -1;
                int number = int.MinValue;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 != 0 && list[i] >= number)
                    {
                        number = list[i];
                        index = i;
                    }
                }
                if (index >= 0)
                {
                    Console.WriteLine(index);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else if (oddOrEven == "even")
            {
                int index = -1;
                int number = int.MinValue;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0 && list[i] >= number)
                    {
                        number = list[i];
                        index = i;
                    }
                }
                if (index >= 0)
                {
                    Console.WriteLine(index);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        private static void exchange(string[] splitInput, List<int> list, List<int> newList)
        {
            int index = int.Parse(splitInput[1]);
            if (index >= list.Count || index < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                newList = list.Take(index + 1).ToList();
                list.AddRange(newList);
                list.RemoveRange(0, index + 1);
            }
        }
    }
}
