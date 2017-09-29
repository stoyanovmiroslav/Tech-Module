using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPeople = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());
            double courses = 0;

            if (numberOfPeople % capacity == 0)
            {
                courses = numberOfPeople / capacity;
            }
            else
            {
                courses = Math.Ceiling(numberOfPeople / capacity);
            }
            Console.WriteLine(courses);
        }
    }
}
