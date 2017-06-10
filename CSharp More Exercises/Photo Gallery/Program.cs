using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            double bytesTotal = 0;
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double bytes = double.Parse(Console.ReadLine());
            int widthRes = int.Parse(Console.ReadLine());
            int heightRes = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: DSC_{0:D4}.jpg", photoNumber);
            Console.WriteLine("Date Taken: {0:D2}/{1:D2}/{2:D4} {3:D2}:{4:D2}", day, month, year, hours, minutes);

            if (bytes <= 1000)
            {
                Console.WriteLine("Size: {0}B", bytes);
            }
            else if(bytes > 1000 && bytes <= 1000000)
            {
                Console.WriteLine("Size: {0}KB", bytes / 1000);
            }
            else
            {
                Console.WriteLine("Size: {0}MB", bytes / 1000000);
            }

            if(widthRes>heightRes)
            {
                Console.WriteLine("Resolution: {0}x{1} (landscape)", widthRes, heightRes);
            }
            else if(widthRes<heightRes)
            {
                Console.WriteLine("Resolution: {0}x{1} (portrait)", widthRes, heightRes);
            }
            else if(widthRes == heightRes)
            {
                Console.WriteLine("Resolution: {0}x{1} (square)", widthRes, heightRes);
            }
        }
    }
}
