using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allwords = File.ReadAllText("text.txt").ToLower().Split(new string[] {"\r", "\n", "-", ",","?",".","\'", " ", "!", ":" , " "}, StringSplitOptions.RemoveEmptyEntries);

            string[] keyWords = File.ReadAllText("words.txt").ToLower().Split(new string[] { "\r", "\n", "-", ",", "?", ".", "\'", " ", "!", ":" }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> findWords = new Dictionary<string, int>();

            for (int i = 0; i < allwords.Length; i++)
            {
                if (keyWords.Contains(allwords[i]))
                {
                    if (!findWords.ContainsKey(allwords[i]))
                    {
                        findWords.Add(allwords[i], 0);
                        findWords[allwords[i]] = 1;
                    }
                    else
                    {
                        findWords[allwords[i]] += 1;
                    }
                }
            }
            foreach (var item in findWords.OrderByDescending(x => x.Value))
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                File.AppendAllText("output.txt", item.Key+ " - " + item.Value+ Environment.NewLine);
            }

            
        }
    }
}
