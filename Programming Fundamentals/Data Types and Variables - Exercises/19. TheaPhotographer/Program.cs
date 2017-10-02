using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaPhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPitures = double.Parse(Console.ReadLine());
            double filterTime = double.Parse(Console.ReadLine());
            double filterFactor = double.Parse(Console.ReadLine());
            double uploadedTime = double.Parse(Console.ReadLine());
           
            double filterPicture = Math.Ceiling(numberOfPitures * filterFactor / 100.0);
            double filterTimeAllPictures = numberOfPitures * filterTime;
            double uploadedTimeFiltredPictures = filterPicture * uploadedTime;
            double totalTime = uploadedTimeFiltredPictures + filterTimeAllPictures;

            TimeSpan seconds = TimeSpan.FromSeconds(totalTime);
            string convertTime = string.Format("{0}:{1:D2}:{2:D2}:{3:D2}",
                            seconds.Days,
                            seconds.Hours,
                            seconds.Minutes,
                            seconds.Seconds);

            Console.WriteLine(convertTime);
        }
    }
}
