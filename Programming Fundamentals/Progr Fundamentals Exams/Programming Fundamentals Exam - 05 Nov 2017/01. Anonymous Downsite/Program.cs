using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            long affectedWebsites = long.Parse(Console.ReadLine());
            long securityKey = long.Parse(Console.ReadLine());

            List<string> namesOfWebsites = new List<string>();
            decimal totalLoss = 0.0M;

            for (int i = 0; i < affectedWebsites; i++)
            {
                string[] dataWebsites = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                decimal siteVisits = decimal.Parse(dataWebsites[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(dataWebsites[2]);
                totalLoss += siteVisits * siteCommercialPricePerVisit;
                
                namesOfWebsites.Add(dataWebsites[0]);
            }
            for (int i = 0; i < namesOfWebsites.Count; i++)
            {
                Console.WriteLine(namesOfWebsites[i]);
            }
     
        BigInteger securityToken = 0;

            securityToken = securityKey;
            for (int i = 0; i < affectedWebsites - 1; i++)
            {
                securityToken = securityToken * securityKey;
            }
                Console.WriteLine("Total Loss: {0:F20}", totalLoss);
                Console.WriteLine("Security Token: {0}", securityToken);
        }
    }
}
