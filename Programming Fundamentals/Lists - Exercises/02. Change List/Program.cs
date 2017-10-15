using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] comand = Console.ReadLine()
                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (comand[0] != "Even" || comand[0] != "Odd")
            {
                if (comand[0] == "Delete")
                {
                    int delete = int.Parse(comand[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == delete)
                        {
                            numbers.Remove(numbers[i]);
                            i--;
                        }
                    }
                 //   Console.WriteLine(String.Join(" ", numbers));
                }
                else if (comand[0] == "Insert")
                {
                    int index = int.Parse(comand[2]);
                    int number = int.Parse(comand[1]);
                    numbers.Insert(index , number);
                  //  Console.WriteLine(String.Join(" ", numbers));
                }
                else if (comand[0] == "Odd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            Console.Write("{0} ", numbers[i]);
                        }
                    }
                    Console.WriteLine();
                    return;
                }
                else if (comand[0] == "Even")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            Console.Write("{0} ", numbers[i]);
                        }
                    }
                    Console.WriteLine();
                    return;
                }
                comand = Console.ReadLine()
                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
