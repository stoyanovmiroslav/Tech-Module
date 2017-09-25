using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
           var volume = int.Parse(Console.ReadLine());
           var energy = int.Parse(Console.ReadLine());
           var sugar = int.Parse(Console.ReadLine());

            double energyfinal = (double)energy * volume / 100;
            double sugarfinal = (double)sugar * volume / 100;

            
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyfinal}kcal, {sugarfinal}g sugars");



        }
    }
}
