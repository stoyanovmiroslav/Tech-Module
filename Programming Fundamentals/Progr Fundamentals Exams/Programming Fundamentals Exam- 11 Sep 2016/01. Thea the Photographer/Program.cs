using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfPicture = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int percentageOfGoodPicture = int.Parse(Console.ReadLine());
            int timeFilterPictureUpload = int.Parse(Console.ReadLine());

            double filtredPicture = Math.Ceiling(amountOfPicture * (percentageOfGoodPicture / 100.0));

            double totalFiltredTime = (double)amountOfPicture * filterTime;
            double totalUploadTime = filtredPicture * timeFilterPictureUpload;

            double totalSeconds = totalFiltredTime + totalUploadTime;

            TimeSpan t = TimeSpan.FromSeconds(totalSeconds);
           // Console.WriteLine(totalFiltredTime + totalUploadTime);
            Console.WriteLine(string.Format("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                            t.Days, 
                            t.Hours,
                            t.Minutes,
                            t.Seconds));
        }   
    }
}
