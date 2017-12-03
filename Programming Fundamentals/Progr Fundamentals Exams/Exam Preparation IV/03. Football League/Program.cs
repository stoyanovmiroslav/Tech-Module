using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string input = "";

            while ((input = Console.ReadLine()) != "final")

            {
                string[] splitInput = input.Split(' ');

                string firsTeamCreapted = splitInput[0];
                string secondTeam = splitInput[1];
                string result = splitInput[2];

                int startIndex = firsTeamCreapted.IndexOf(key) + key.Length;
                int endIndex = firsTeamCreapted.LastIndexOf(key);


                string firstTeam = firsTeamCreapted.Substring(startIndex , endIndex - startIndex);
                char[] firstTeamArr = firstTeam.Reverse().ToArray();
                firstTeam = string.Join("", firstTeamArr).ToUpper();


                
            }
        }
    }
}
