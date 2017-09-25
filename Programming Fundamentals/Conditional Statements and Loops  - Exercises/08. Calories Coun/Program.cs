using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Coun
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLoop = int.Parse(Console.ReadLine());
            double sum = 0.00;

            for (int i = 0; i < countLoop; i++)
            {
                string ingredient = Console.ReadLine().ToLower();

                if (ingredient == "cheese")
                {
                    sum += 500;
                }
                else if (ingredient == "tomato sauce")
                {
                    sum += 150;
                }
                else if (ingredient == "salami")
                {
                    sum += 600;
                }
                else if (ingredient == "pepper")
                {
                    sum += 50;
                }
            }
            Console.WriteLine($"Total calories: {sum}");

        }
    }
}
