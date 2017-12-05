using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([0-9]+)([a-zA-Z]+)([^a-zA-Z]*)$";
            string input = "";

            while ((input = Console.ReadLine()) != "Over!")
            {
                int messageLenght = int.Parse(Console.ReadLine());
                foreach (Match m in Regex.Matches(input, pattern))
                {
                    string messages = m.Groups[2].ToString();
                    if (messages.Length == messageLenght)
                    {
                        StringBuilder sb = new StringBuilder();
                        char[] arrStartIndexes = m.Groups[1].ToString().ToCharArray();
                        char[] arrEndIndexes = m.Groups[3].ToString().ToCharArray();
                        sb = VerificationCode(arrStartIndexes, messages, sb);
                        sb = VerificationCode(arrEndIndexes, messages, sb);
                        Console.WriteLine("{0} == {1}", messages, sb);
                    }
                }
            }
        }

        private static StringBuilder VerificationCode(char[] arr, string messages, StringBuilder sb)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                try
                {
                    int a = int.Parse(arr[j].ToString());
                    if (a >= 0 && a < messages.Length)
                    {
                        sb.Append(messages.Substring(a, 1));
                    }
                    else
                    {
                        sb.Append(" ");
                    }
                }
                catch (Exception)
                {
                    sb.Append(" ");
                }

            }
            return sb;
        }
    }
}
