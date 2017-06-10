using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaPixels
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double result = 0;
            double megapix = 0;

            result = width * height;
            megapix = result / 1000000;
            Console.WriteLine("{0}x{1} => {2}MP", width, height, Math.Round(megapix, 1));
        }
    }
}
