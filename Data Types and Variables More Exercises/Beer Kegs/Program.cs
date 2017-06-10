using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            string biggest = "";
            double volume = 0;

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                var r = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());

                var cunVolume = volume;
                volume = Math.PI * (r * r) * h;

                if (volume > cunVolume)
                {
                    cunVolume = volume;
                    biggest = s;
                }
            }

            Console.WriteLine(biggest);
        }
    }
}
