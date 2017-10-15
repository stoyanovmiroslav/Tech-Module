using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                                .ToLower()
                                .Split(new string[] { ".", ",", ":", ";", "(", ")", "[", "]", "\"", "\'", "\\", "/", "!", "?", " " }, StringSplitOptions.RemoveEmptyEntries)
                                .ToList();

           var newWords = words.Where(x => x.Length < 5)
                .Distinct()
                .OrderBy(x => x)
                .ToList();
          
            Console.WriteLine(String.Join(", ", newWords));
        }
    }
}
