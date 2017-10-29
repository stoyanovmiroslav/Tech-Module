using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new string[] { " ", "/", "\\", "(", ")" }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"(^|\s)[a-zA-Z][A-Za-z0-9_]+";
            List<string> userNames = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length >= 3 && input[i].Length <= 25)
                {
                    foreach (Match m in Regex.Matches(input[i], pattern))
                    {
                        if (m.Success)
                        {
                            userNames.Add(m.Value);
                        }
                    }
                }
            }
            int currentLenght = 1;
            int index = 0;
            for (int i = 0; i < userNames.Count-1; i++)
            {
                if (userNames[i].Length + userNames[i+1].Length > currentLenght)
                {
                    currentLenght = userNames[i].Length + userNames[i + 1].Length;
                    index = i;
                }
            }
            Console.WriteLine(userNames[index]);
            Console.WriteLine(userNames[index + 1]);
        }
    }
}
