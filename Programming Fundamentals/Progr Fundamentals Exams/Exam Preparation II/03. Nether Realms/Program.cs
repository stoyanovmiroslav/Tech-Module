using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new String[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
            string patternHealth = @"[^0-9+-.*\/]";
            string patternDamage = @"([-+]?[0-9.]+)";
            string patternMultiplyingDividing = @"([*\/])";
            
            Dictionary<String, Dictionary<double, double>> dictNetherRealms = new Dictionary<String, Dictionary<double, double>>();
            for (int i = 0; i < input.Length; i++)
            {
                double sumOfHealth = 0;
                double sumOfDamage = 0;
                foreach (Match m in Regex.Matches(input[i], patternHealth))
                {
                    char[] toChar = m.Value.ToCharArray();
                    sumOfHealth += (int)toChar[0];
                }
                foreach (Match m in Regex.Matches(input[i], patternDamage))
                {
                    sumOfDamage += double.Parse(m.Value);
                }
                foreach (Match m in Regex.Matches(input[i], patternMultiplyingDividing))
                {
                    if (m.Value == "/")
                    {
                        sumOfDamage = sumOfDamage / 2; 
                    }
                    else if (m.Value == "*")
                    {
                        sumOfDamage = sumOfDamage * 2;
                    }
                }
                dictNetherRealms.Add(input[i], new Dictionary<double, double>());
                dictNetherRealms[input[i]].Add(sumOfHealth, sumOfDamage);
            }

            foreach (var dict in dictNetherRealms.OrderBy(x => x.Key))
            {
                foreach (var item in dict.Value)
                {
                    Console.WriteLine("{0} - {1} health, {2:f2} damage", dict.Key, item.Key, item.Value);
                }
            }
        }
    }
}
