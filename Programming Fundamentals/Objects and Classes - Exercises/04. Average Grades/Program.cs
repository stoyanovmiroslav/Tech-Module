using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Students> listOfStudents = new List<Students>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                Students students = new Students();
                string[] input = Console.ReadLine().Split(' ');
                students.Name = input[0];
                students.ListOfGrades = input.Skip(1).Select(double.Parse).ToArray();
                listOfStudents.Add(students);
            }

           listOfStudents.Where(x => x.Avarage >= 5.00)
                           .OrderBy(x => x.Name)
                           .ThenByDescending(x => x.Avarage)
                           .ToList()
                           .ForEach(x => Console.WriteLine($"{x.Name} -> {x.Avarage:F2}"));
        }
        class Students
        {
            public string Name { get; set; }
            public double[] ListOfGrades { get; set; }
            public double Avarage => ListOfGrades.Average();
        }
    }
}
