using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([A-Z]{2})([0-9]+\.[0-9]+)([A-z]+)(\|)";

            List<Weather> listOfWeathe = new List<Weather>();

            while (input != "end")
            {
                Weather newCityTemperature = new Weather();
                bool exist = false;
                foreach (Match m in Regex.Matches(input, pattern))
                {
                    newCityTemperature.City = m.Groups[1].ToString();
                    newCityTemperature.Temperature = double.Parse(m.Groups[2].ToString());
                    newCityTemperature.TypeOfWeather = m.Groups[3].ToString();

                    for (int i = 0; i < listOfWeathe.Count; i++)
                    {
                        if (listOfWeathe[i].City.Contains(m.Groups[1].ToString()))
                        {
                            exist = true;
                            listOfWeathe[i].Temperature = double.Parse(m.Groups[2].ToString());
                            listOfWeathe[i].TypeOfWeather = m.Groups[3].ToString();
                        }
                    }
                    if (!exist)
                    {
                        listOfWeathe.Add(newCityTemperature);
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var item in listOfWeathe.OrderBy(x => x.Temperature))
            {
                Console.WriteLine("{0} => {1:F2} => {2}", item.City, item.Temperature, item.TypeOfWeather);
            }
        }
        class Weather
        {
            public string City { get; set; }
            public double Temperature { get; set; }
            public string TypeOfWeather { get; set; }
        }
    }
}
