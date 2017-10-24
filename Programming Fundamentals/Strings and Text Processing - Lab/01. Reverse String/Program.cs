using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToCharArray().Reverse();
            Console.WriteLine(string.Join("", text));
        }
    }
}
