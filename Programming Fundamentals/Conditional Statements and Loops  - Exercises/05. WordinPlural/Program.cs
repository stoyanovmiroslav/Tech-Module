using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            if (name.EndsWith("o") || name.EndsWith("ch") || name.EndsWith("s") || name.EndsWith("sh")
                || name.EndsWith("x") || name.EndsWith("z"))
            {
                Console.WriteLine(name + "es");
            }
            else if (name.EndsWith("y"))
            {
                name = name.Remove(name.Length - 1);
                Console.WriteLine(name + "ies");
            }
            else
            {
                Console.WriteLine(name + "s");
            }

        }
    }
}

