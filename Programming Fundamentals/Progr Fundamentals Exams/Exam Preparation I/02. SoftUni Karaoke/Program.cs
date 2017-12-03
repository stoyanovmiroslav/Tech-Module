using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            string[] allSongs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            var dictParticipantsAwards = new Dictionary<string, List<string>>();

            string input = ""; 
            while ((input = Console.ReadLine()) != "dawn")
            {
                string[] splitInput = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                string currentParticipant = splitInput[0];
                string currentSong = splitInput[1];
                string currentAward = splitInput[2];

                if (participants.Contains(currentParticipant) && allSongs.Contains(currentSong))
                {
                    if (!dictParticipantsAwards.ContainsKey(currentParticipant))
                    {
                        dictParticipantsAwards.Add(currentParticipant, new List<string>());
                        dictParticipantsAwards[currentParticipant].Add(currentAward);
                    }
                    else if (!dictParticipantsAwards[currentParticipant].Contains(currentAward))
                    {
                        dictParticipantsAwards[currentParticipant].Add(currentAward);
                    }
                }
                   
            }

            foreach (var participant in dictParticipantsAwards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0}: {1} awards", participant.Key, participant.Value.Count);
                foreach (var award in participant.Value.OrderBy(x => x))
                {
                    Console.WriteLine("--{0}", award);
                }
            }

            if (dictParticipantsAwards.Values.Count == 0)
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
