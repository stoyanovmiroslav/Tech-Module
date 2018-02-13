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
            List<Teams> listOfTeams = new List<Teams>();
            while ((input = Console.ReadLine()) != "final")
            {
                string[] splitInput = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string teamA = findTeam(splitInput[0], key);
                string teamB = findTeam(splitInput[1], key);
                int[] result = splitInput[2]
                    .Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                int teamAGoals = result[0];
                int teamBGoals = result[1];
                int teamAPoints = CalculateTeamPoints(teamAGoals, teamBGoals);
                int teamBPoints = CalculateTeamPoints(teamBGoals, teamAGoals);

                for (int j = 0; j < 2; j++)
                {
                    Teams team = new Teams();
                    if (j == 1)
                    {
                        team.Name = teamA;
                        team.Points = teamAPoints;
                        team.Goals = teamAGoals;
                    }
                    else
                    {
                        team.Name = teamB;
                        team.Points = teamBPoints;
                        team.Goals = teamBGoals;
                    }

                    bool contain = false;
                    for (int i = 0; i < listOfTeams.Count; i++)
                    {
                        if (listOfTeams[i].Name == team.Name)
                        {
                            listOfTeams[i].Goals += team.Goals;
                            listOfTeams[i].Points += team.Points;
                            contain = true;
                        }
                    }
                    if (!contain)
                    {
                        listOfTeams.Add(team);
                    }
                }
            }
            int count = 1;
            Console.WriteLine("League standings:");
            foreach (var item in listOfTeams.OrderByDescending(x => x.Points).ThenBy(x => x.Name))
            {
                Console.WriteLine("{0}. {1} {2}", count, item.Name, item.Points);
                count++;
            }
            count = 0;
            Console.WriteLine("Top 3 scored goals:");
            foreach (var item in listOfTeams.OrderByDescending(x => x.Goals).ThenBy(x => x.Name))
            {
                Console.WriteLine("- {0} -> {1}", item.Name, item.Goals);
                count++;
                if (count == 3)
                {
                    break;
                }
            }
        }

        private static int CalculateTeamPoints(int teamAGoals, int teamBGoals)
        {
            if (teamAGoals == teamBGoals)
            {
                return 1;
            }
            else if (teamAGoals > teamBGoals)
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }

        private static string findTeam(string input, string key)
        {
            int keyStart = input.IndexOf(key);
            input = input.Remove(0, keyStart + key.Length);
            int keyEnd = input.IndexOf(key);
            string team = (input.Substring(0, keyEnd)).ToUpper();
            char[] charArray = team.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
    public class Teams
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public int Goals { get; set; }
    }
}
