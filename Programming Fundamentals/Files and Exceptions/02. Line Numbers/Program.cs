using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");

            for (int i = 1; i <= lines.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i, lines[i-1]);

              File.AppendAllText("output.txt", i + ". " + lines[i-1] + Environment.NewLine);
            }
        }
    }
}
