using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredien
{
    class Program
    {
        static void Main(string[] args)
        {

            int cout = 0;

            for (int i = 0; i <= 20; i++)
            {
                string ingrediant = Console.ReadLine();
                if (ingrediant == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {cout} ingredients.");
                    return;
                }
                Console.WriteLine($"Adding ingredient {ingrediant}.");
                cout++;
            }
           

            
        }
    }
}
