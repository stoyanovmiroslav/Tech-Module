using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int remainedN = n;
            int checkPercent = n / 2;
            int count= 0;
                                                        
            while (remainedN >= m)                      
            {     
                if (remainedN == checkPercent && remainedN >= y && y > 0)
                {
                    remainedN = remainedN / y;
                }
                if (remainedN >= m)
                {
                    remainedN -= m;
                    count++;
                }
            }
            Console.WriteLine(remainedN);
            Console.WriteLine(count);
        }
    }
}
