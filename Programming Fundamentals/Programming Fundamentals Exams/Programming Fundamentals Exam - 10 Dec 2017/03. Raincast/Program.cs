using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string typeOutput = "";
            string typeForecast = "";
            string typeSource = "";
            string pattern = @"[^a-zA-Z0-9]";

            while ((input = Console.ReadLine()) != "Davai Emo")
            {
                string[] inputArg = input.Split(new string[] { ": " },StringSplitOptions.RemoveEmptyEntries);
                string command = "";
                string output = "";
                try
                {
                   command = inputArg[0];
                   output = inputArg[1];
                }
                catch (Exception)
                {

                    continue;
                }  

                if ((command == "Type" && typeOutput == "") && (output == "Normal" || output == "Warning" || output == "Danger"))
                {
                    typeOutput = output;
                    continue;
                }
                else if(typeOutput == "")
                {
                    continue;
                }

                if (command == "Source" && typeForecast == "")
                {
                    int count = 0;
                    foreach (Match m in Regex.Matches(output, pattern))
                    {
                        count++;
                    }

                    if (count == 0)
                    {
                        typeForecast = output;
                        continue;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (typeForecast == "")
                {
                    continue;
                }

                if (command == "Forecast" && typeSource == "")
                {
                    int check1 = output.IndexOf("!");
                    int check2= output.IndexOf(".");
                    int check3 = output.IndexOf(",");
                    int check4 = output.IndexOf("?");

                    if (check1 >= 0 || check2 >= 0 || check3 >= 0 || check4 >= 0)
                    {
                        continue;
                    }
                    
                    typeSource = output;
                }
                else if (typeSource == "")
                {
                    continue;
                }

                Console.WriteLine("({0}) {2} ~ {1}", typeOutput, typeForecast, typeSource);


                typeOutput = "";
                typeForecast = "";
                typeSource = "";
            }
        }
    }
}
