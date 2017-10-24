using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ', '.', ',', '?', '!' } , StringSplitOptions.RemoveEmptyEntries);
            List<String> listOfPalindromes = new List<String>();

            for (int i = 0; i < text.Length; i++)
            {
               bool isTrueOrFalse = IsPalindrome(text[i]);
                if (isTrueOrFalse)
                {
                    listOfPalindromes.Add(text[i]);
                }
            }

            listOfPalindromes = listOfPalindromes.OrderBy(x => x).Distinct().ToList();
            Console.WriteLine(string.Join(", ", listOfPalindromes));

        }

        private static bool IsPalindrome(string word)
        {
            string reversed = new string(word.Reverse().ToArray());
            if (reversed == word)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}