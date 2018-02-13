using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyCash = double.Parse(Console.ReadLine());
            int numberOfGuest = int.Parse(Console.ReadLine());
            double priceOfBananas = double.Parse(Console.ReadLine());
            double priceOfEggs = double.Parse(Console.ReadLine());
            double priceOfBerries = double.Parse(Console.ReadLine());
       
            double setsOfPortion = Math.Ceiling(numberOfGuest / 6.0);
            double productsPice = setsOfPortion * (2 * priceOfBananas + 4 * priceOfEggs + 0.2 * priceOfBerries);

            if (productsPice <= moneyCash)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.", productsPice);
            }
            else
            {
                double needMoney = productsPice - moneyCash;
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", needMoney);
            }  
        }
    }
}
