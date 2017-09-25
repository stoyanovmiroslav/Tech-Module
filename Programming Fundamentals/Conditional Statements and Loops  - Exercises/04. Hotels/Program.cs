using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotels
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounths = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());
            double studio = 0.0;
            double doubleroom = 0.0; 
            double suite = 0.0;
          
  
            if (mounths == "May" || mounths == "October")
            {
                if (numberOfNights <= 7)
                    studio = 50;
                else
                    studio = 50*0.95;

                doubleroom = 65;
                suite = 75;
            }
            else if (mounths == "June" || mounths == "September")
            {
                if (numberOfNights <= 14)
                    doubleroom = 72;
                else
                    doubleroom = 72 * 0.9;

                    studio = 60;
                suite = 82;
            }
            else if (mounths == "July" || mounths == "August" || mounths == "December")
            {
                studio = 68;
                doubleroom = 77;
                if (numberOfNights <= 14)
                    suite = 89;
                else
                    suite = 89 * 0.85;  
            }
            if (mounths == "September" || mounths == "October" && numberOfNights > 7)
            {
                double studioprice = studio * numberOfNights - studio;
                Console.WriteLine($"Studio: {studioprice:F2} lv.");
            }
            else
            {
                double studioprice = studio * numberOfNights;
                Console.WriteLine($"Studio: {studioprice:F2} lv.");
            }
  
            double doubleroomPrice = doubleroom * numberOfNights;
            double suitePrice = suite * numberOfNights;

            Console.WriteLine($"Double: {doubleroomPrice:F2} lv.");
            Console.WriteLine($"Suite: {suitePrice:F2} lv.");

            
        }
    }
}
