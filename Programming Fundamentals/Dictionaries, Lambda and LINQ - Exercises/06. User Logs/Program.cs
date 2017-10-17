using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                           .Split(' ');

            var userLogs = new Dictionary<string, Dictionary<string, int>>();

            while (input[0] != "end")
            {
                string[] splitIp = input[0].Split('=');
                string ip = splitIp[1];
                string[] splitUsername = input[2].Split('=');
                string user = splitUsername[1];

                if (!userLogs.ContainsKey(user))
                {
                    userLogs.Add(user, new Dictionary<string, int>());
                    userLogs[user].Add(ip, 0);
                }
                else if (!userLogs[user].ContainsKey(ip))
                {
                    userLogs[user].Add(ip, 0);
                }
             
                userLogs[user][ip] += 1;
                input = Console.ReadLine()
                           .Split(' ');
            }

            foreach (var names in userLogs.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0}: ", names.Key);
                var counter = 0;

                foreach (var count in names.Value)
                {
                    Console.Write("{0} => {1}", count.Key, count.Value );
                    counter++;
                    if (names.Value.Count == counter)
                    {
                        Console.WriteLine(". ");
                    }
                    else
                    {
                        Console.Write(", ");
                    }
                }
            }
        }
    }
}
