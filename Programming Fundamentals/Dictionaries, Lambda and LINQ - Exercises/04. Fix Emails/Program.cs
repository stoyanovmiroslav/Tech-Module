using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            if (name.ToLower() == "stop") return;
            string email = "";

            Dictionary<string, string> dict = new Dictionary<string, string>();

            while(name.ToLower() != "stop" || email.ToLower() != "stop")
            {
                name = Console.ReadLine();
                if (name.ToLower() == "stop") break;
                email = Console.ReadLine();

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, email);
                }
                else
                {
                    dict[name] = email;
                }

                string check = email.Substring(email.Length - 2);

                 if (check == "uk" || check == "us")
                 {
                    dict.Remove(name);
                 }


             
            }

            foreach (var item in dict.Keys)
            {
                Console.WriteLine(item + " -> " + dict[item]);
            }
        }
    }
}
