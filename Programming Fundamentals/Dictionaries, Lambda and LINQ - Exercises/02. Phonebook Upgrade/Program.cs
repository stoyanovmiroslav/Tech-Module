using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ');

            var phonebook = new SortedDictionary<string, string>();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    //phonebook.Add(input[1], input[2]);
                    phonebook[input[1]] = input[2];
                }
                else if (input[0] == "S")
                {
                    if (phonebook.ContainsKey(input[1]))
                    {
                        Console.WriteLine(input[1] + " -> " + phonebook[input[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", input[1]);
                    }

                }
                else if (input[0] == "ListAll")
                {
                    phonebook.OrderBy(x => x);

                    foreach (var item in phonebook.Keys)
                    {
                        Console.WriteLine(item + " -> " + phonebook[item]);
                    }
                }
                input = Console.ReadLine().Split(' ');
            }
        }
    }
}
