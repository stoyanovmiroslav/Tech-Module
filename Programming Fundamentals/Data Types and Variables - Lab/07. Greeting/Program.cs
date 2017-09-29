using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());


            Console.WriteLine($"Hello, {name} {surname}. You are {age} years old.");
        }
    }
}
