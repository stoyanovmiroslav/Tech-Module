using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int givenPower = int.Parse(Console.ReadLine());

            double raisedNumber = GetRaisedNumber(number, givenPower);
            Console.WriteLine(raisedNumber);
        }

        private static double GetRaisedNumber(double number, int givenPower)
        {
            double raisedNumber = 1d;
            for (int i = 1; i <= givenPower; i++)
            {
                raisedNumber *= number;
            }
            return raisedNumber;
        }
    }
}
