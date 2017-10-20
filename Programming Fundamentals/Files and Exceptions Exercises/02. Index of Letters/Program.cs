using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = File.ReadAllText("Input.txt");

            for (int i = 0; i < word.Length; i++)
            {
                File.AppendAllText("output.txt", $"{word[i]} -> {(int)word[i] - 97}" + Environment.NewLine);
            }
        }
    }
}
