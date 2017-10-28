using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_Sentences_by_Keyword
{
    class Program
    {
        public static void Main()
        {
            string pattern = @"([A-Za-z\s,0-9-'$&+,:;=@#|'<>^*()%]+[\W]?( |,|:|.)" + Console.ReadLine()
               + @"\b[A-Za-z\s,0-9-'$&+,:;=@#|'<>^*()%]+[\W]?[.!?])";
            string input = Console.ReadLine();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine("{0}", m.Value.Split('.', '!', '?'));
            }
        }
    }
}
