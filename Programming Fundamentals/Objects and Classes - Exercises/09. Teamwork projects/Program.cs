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
                newTeam.Creator = input[0];
                newTeam.Teams = input[1];
                bool teamExist = false;

                for (int j = 0; j < listOfTeams.Count; j++)
                {
                    if (listOfTeams[j].Teams.Contains(newTeam.Teams))
                    {
                        Console.WriteLine($"Team {newTeam.Teams} was already created!");
                        teamExist = true;
                        break;
                    }
                    if (listOfTeams[j].Creator.Contains(newTeam.Creator))
                    {
                        Console.WriteLine($"{newTeam.Creator} cannot create another team!");
                        teamExist = true;
                        break;
                    }
                }
                if (!teamExist)
                {
                    listOfTeams.Add(newTeam);
                    Console.WriteLine($"Team {input[1]} has been created by {input[0]}!");
                }
            }
         
                while (input[0] != "end of assignment")
                {
                    string secondInput = Console.ReadLine();
                    if (secondInput == "end of assignment")
                    {
                        break;
                    }
                    input = secondInput.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries).ToList();

                    Team team = new Team();

                team.Teams = input[1];
                string nameMember = input[0];

                for (int i = 0; i < listOfTeams.Count; i++)
                    {
                        if (listOfTeams[i].Teams.Contains(team.Teams))
                        {
                            if (listOfTeams[i].Creator == nameMember)
                            {
                                Console.WriteLine($"Member {nameMember} cannot join team {team.Teams}!");
                                break;
                            }
                            else if (listOfTeams[i].Members == null)
                            {
                                listOfTeams[i].Members = new List<string>();
                                listOfTeams[i].Members.Add(nameMember);
                                break;
                            }
                            else if (!listOfTeams[i].Members.Contains(nameMember))
                            {
                                listOfTeams[i].Members.Add(nameMember);
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Member {nameMember} cannot join team {team.Teams}!");
                                break;
                            }

                        }
                        else if (listOfTeams.Count - 1 == i)
                        {
                            Console.WriteLine($"Team {team.Teams} does not exist!");
                            break;
                        }
                    }

                }
                List<Team> listOfdisband = new List<Team>();
                listOfdisband = listOfTeams.Where(x => x.Members == null).ToList();
                listOfTeams = listOfTeams.Where(x => x.Members != null).ToList();
           

                foreach (var item in listOfTeams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Teams))
                {
                    Console.WriteLine("{0}", item.Teams);
                    Console.WriteLine("- {0}", item.Creator);

                    foreach (var member in item.Members.OrderBy(x => x))
                    {
                        Console.WriteLine("-- {0}", member);
                    }
                }
                Console.WriteLine("Teams to disband:");

                foreach (var team in listOfdisband.OrderBy(x => x.Teams))
                {
                    Console.WriteLine("{0}", team.Teams);
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
