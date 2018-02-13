using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string patternMessages = @"^([0-9]+) <-> ([A-Za-z0-9]+)$";
            string patternBroadcast = @"^([^0-9]+) <-> ([A-Za-z0-9]+)$";

            List<string> listOfMessages = new List<string>();
            List<string> listOfBroadcast = new List<string>();

            while ((input = Console.ReadLine()) != "Hornet is Green")
            {
                foreach (Match m in Regex.Matches(input, patternMessages))
                {
                    string reverse = String.Join("", m.Groups[1].ToString().ToCharArray().Reverse().ToArray());
                    
                    listOfMessages.Add(reverse);
                    listOfMessages.Add(m.Groups[2].ToString());
                }
                foreach (Match m in Regex.Matches(input, patternBroadcast))
                {
                    char[] findUpperLower = m.Groups[2].ToString().ToCharArray();
                    for (int i = 0; i < findUpperLower.Length; i++)
                    {
                        if (char.IsLower(findUpperLower[i]))
                        {
                           string lowerToUpper =  findUpperLower[i].ToString().ToUpper();
                           findUpperLower[i] = lowerToUpper[0];
                        }
                        else if (char.IsUpper(findUpperLower[i]))
                        {
                            string upperToLower = findUpperLower[i].ToString().ToLower();
                            findUpperLower[i] = upperToLower[0];
                        }
                    }
                    listOfBroadcast.Add(String.Join("", findUpperLower));
                    listOfBroadcast.Add(m.Groups[1].ToString());
                }
            }
            Console.WriteLine("Broadcasts:");
            for (int i = 0; i < listOfBroadcast.Count; i=i+2)
            {
                Console.WriteLine("{0} -> {1}", listOfBroadcast[i], listOfBroadcast[i+1]); 
            }
            if (listOfBroadcast.Count == 0)
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");
            for (int i = 0; i < listOfMessages.Count; i= i+2)
            {
                Console.WriteLine("{0} -> {1}", listOfMessages[i], listOfMessages[i + 1]);
            }
            if (listOfMessages.Count == 0)
            {
                Console.WriteLine("None");
            }
        }
    }
}
