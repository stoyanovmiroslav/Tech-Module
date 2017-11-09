using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            for (int i = 0; i < n; i++)
            {
                decimal price = CalculateOrder();
                totalPrice += price;
            }
            Console.WriteLine("Total: ${0:F2}", totalPrice);
        }

        private static decimal CalculateOrder()
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            string dateInput = Console.ReadLine();
            decimal capsulesCount = decimal.Parse(Console.ReadLine());
            DateTime date = DateTime.ParseExact(dateInput, "d/M/yyyy", CultureInfo.InvariantCulture);
            decimal daysInMonth =  DateTime.DaysInMonth(date.Year, date.Month);

            decimal price = (daysInMonth * capsulesCount) * pricePerCapsule;
            Console.WriteLine($"The price for the coffee is: ${price:F2}");
            return price;
        }
    }
}
