using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Use_Your_Chains__Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string firstPattern = @"<p>(.*?)<\/p>";  // group1   
            string secondPattern1 = @"[a-z0-9]+";
            string secondPattern = @"[\WA-Z]+";


            List<string> sentence = new List<string>();
            foreach (Match m in Regex.Matches(input, firstPattern))
            {
                string[] results = Regex.Split(m.Groups[1].ToString(), secondPattern);
                string group = string.Join(" ", results);
                sentence.Add(group);
            }

            var sentenceToChar = string.Join("", sentence).ToCharArray();

            for (int i = 0; i < sentenceToChar.Length; i++)
            {
                if (sentenceToChar[i] >= 'n' && sentenceToChar[i] <= 'z')
                {
                    sentenceToChar[i] = (char)((int)sentenceToChar[i] - 13);
                }else if (sentenceToChar[i] >= 'a' && sentenceToChar[i] <= 'm')
                {
                    sentenceToChar[i] = (char)((int)sentenceToChar[i] + 13);
                }
            }
            Console.WriteLine(string.Join("", sentenceToChar));
        }
    }
}
