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
            string firstPattern = @"<p>(.*?)<\/p>";
            string secondPattern = @"[\WA-Z]+";
            
            List<string> sentence = new List<string>();
            foreach (Match m in Regex.Matches(input, firstPattern))
            {
                string[] splitNotSmallLattersAndNumbers = Regex.Split(m.Groups[1].ToString(), secondPattern);
                string words = string.Join(" ", splitNotSmallLattersAndNumbers);
                sentence.Add(words);
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
