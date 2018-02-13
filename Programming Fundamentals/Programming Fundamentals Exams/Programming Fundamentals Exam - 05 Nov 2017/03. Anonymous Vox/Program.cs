using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] values = Console.ReadLine().Split(new string[] { "{", "}" }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"(.*?)([a-zA-Z]+)(.*)(\2)(.*)";
            int index = 0;
            StringBuilder sb = new StringBuilder();
            bool isMatch = true;
            while (isMatch)
            {
                isMatch = false;
                foreach (Match m in Regex.Matches(input, pattern))
                {                                                  
                    sb.Append(m.Groups[1].ToString() + m.Groups[2].ToString()+ values[index] + m.Groups[4].ToString());
                    input = m.Groups[5].ToString();
                    isMatch = true;
                    index++;
                }
            }
            sb.Append(input);
            Console.WriteLine(sb);
        }
    }
}
