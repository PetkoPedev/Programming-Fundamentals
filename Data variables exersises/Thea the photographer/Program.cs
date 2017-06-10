using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_the_photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var picturesCount = int.Parse(Console.ReadLine());
            var singlePictureFilterTimeSeconds = int.Parse(Console.ReadLine());
            var filterPercentage = int.Parse(Console.ReadLine());
            var singlePictureUploadTimeSeconds = int.Parse(Console.ReadLine());

            var filterTimeSeconds = (long)picturesCount * singlePictureFilterTimeSeconds;
            var picturesToUploadCount = (long)Math.Ceiling(picturesCount * (filterPercentage / 100d));
            var uploadTimeSeconds = picturesToUploadCount * singlePictureUploadTimeSeconds;
            var totalTimeNeededSeconds = filterTimeSeconds + uploadTimeSeconds;
            var totalTimeNeededTimeSpan = TimeSpan.FromSeconds(totalTimeNeededSeconds);
            Console.WriteLine(totalTimeNeededTimeSpan.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
