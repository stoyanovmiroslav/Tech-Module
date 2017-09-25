using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int magica = 0;
            int magicc = 0;
            var combinatio = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    if (i + j == magic)
                    {
                        magica = i;
                        magicc = j;
                    }
                    combinatio++;
                }
            }
            if (magica == 0)
            {
                Console.WriteLine($"{combinatio} combinations - neither equals {magic}");
            }
            else
            {
                Console.WriteLine($"Number found! {magica} + {magicc} = {magic}");
            }

        }
    }
}
