using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Mentor_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Student> dictStudents = new Dictionary<string, Student>();
           

            while (input != "end of dates")
            {
                string[] splitInput = input.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);

                string name = splitInput[0];
                Student currentStudent = new Student();
                currentStudent.DateTime = new List<DateTime>();

                currentStudent.Name = name;

                if (!dictStudents.ContainsKey(name))
                {
                    for (int i = 1; i < splitInput.Length; i++)
                    {
                        DateTime date = DateTime.ParseExact(splitInput[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        currentStudent.DateTime.Add(date);
                    }
                    dictStudents.Add(name, currentStudent);
                }
                else
                {
                    for (int i = 1; i < splitInput.Length; i++)
                    {
                        DateTime date = DateTime.ParseExact(splitInput[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        dictStudents[name].DateTime.Add(date);
                    }
                }
                

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            string[] names = input.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
            

            while (input != "end of comments")
            {
                names = input.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);


                string[] splitInput = input.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
                string name = splitInput[0];
                string coments = splitInput[1];
               
                if (dictStudents.ContainsKey(name))
                {
                    if (dictStudents[names[0]].Coments == null)
                    {
                        dictStudents[names[0]].Coments = new List<string>();
                    }
                    dictStudents[name].Coments.Add(coments);
                }

                input = Console.ReadLine();
            }

            foreach (var name in dictStudents.OrderBy(x => x.Key))
                {
                Console.WriteLine(name.Key);

                Console.WriteLine("Comments:");
                if (name.Value.Coments != null)
                {
                    foreach (var coments in name.Value.Coments)
                    {
                        Console.WriteLine("- {0} ", coments);
                    }
                }
                Console.WriteLine("Dates attended:");
                if (name.Value.DateTime != null)
                {
                    foreach (var date in name.Value.DateTime.OrderBy(x => x))
                    {
                        Console.WriteLine("-- {0:dd/MM/yyyy}", date);
                    }
                }
            }
        }

    }
    class Student
    {
        public string Name { get; set; }
        public List<string> Coments { get; set; }
        public List<DateTime> DateTime { get; set; }
    }
}
