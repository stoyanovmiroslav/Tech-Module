using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());
            min = min + 30;
            if (min > 59)
            {
                hour++;
                if (hour > 23)
                 hour = 0;
                
                min = min - 60;
            }
            Console.WriteLine($"{hour}:{min:D2}");
        }
    }
}
