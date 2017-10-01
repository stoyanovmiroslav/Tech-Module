using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Amanda";
            string surname = "Jonson";
            sbyte age = 27;
            char genger = 'f';
            long personalId = 8306112507;
            int emploeeNumber = 27563571;

            Console.WriteLine("First name: " + name + Environment.NewLine + "Last name: " + surname
                + Environment.NewLine + "Age: " + age + Environment.NewLine + "Gender: " + genger 
                + Environment.NewLine + "Personal ID: " + personalId + Environment.NewLine 
                + "Unique Employee number: " + emploeeNumber);
        }
    }
}
