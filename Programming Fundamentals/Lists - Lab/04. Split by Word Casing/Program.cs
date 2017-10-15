using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[]
             {'.',',',':',';','(',')','\"','!','\'','\\','/','[',']',' '};
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<string> allWords = new List<string>(words);

            List<string> lowercase = new List<string>();
            List<string> uppercase = new List<string>();
            List<string> mixedcase = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                   
                if (words[i].All(char.IsUpper))
                {
                    uppercase.Add(words[i]);
                }
                else if (words[i].All(char.IsLower))
                {
                    lowercase.Add(words[i]);
                }
                else
                {
                    mixedcase.Add(words[i]);
                }
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", lowercase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedcase));
            Console.WriteLine("Upper-case: " + string.Join(", ", uppercase));
        }
    }
}
