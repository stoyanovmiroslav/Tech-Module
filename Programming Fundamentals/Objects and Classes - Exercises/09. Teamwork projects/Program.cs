using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Teamwork_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> listOfTeams = new List<Team>();

            List<string> input = new List<string>();

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split('-').ToList();
                Team newTeam = new Team();

                for (int j = 0; j < newTeam.Teams.Length; j++)
                {
                    if (newTeam.Teams[i] == input[1])
                    {

                    }
                }
                    newTeam.Creator = input[0];
                    newTeam.Teams = input[1];
                    listOfTeams.Add(newTeam);
                    Console.WriteLine($"Team {input[1]} has been created by {input[0]}!");
            }

            while (input[0] != "end of assignment")
            {
                input = Console.ReadLine().Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                Team team = new Team();
                team.Teams = input[1];
                team.Members = new List<string>();
                team.Members.Add(input[0]);
            }
    }
}
class Team
{
    public List<string> Members { get; set; }
    public string Creator { get; set; }
    public string Teams { get; set; }

}
}
