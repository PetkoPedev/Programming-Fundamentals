using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string cinema = Console.ReadLine().ToLower();
            var r = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            double ticket;
            double result;
            if (cinema == "premiere")
            {
                ticket = 12.00;
                result = r * c * ticket;
                Console.WriteLine("{0:f2} leva", result);
            }
            else if (cinema == "normal")
            {
                ticket = 7.50;
                result = r * c * ticket;
                Console.WriteLine("{0:f2} leva", result);
            }
            else if (cinema == "discount")
            {
                ticket = 5.00;
                result = r * c * ticket;
                Console.WriteLine("{0:f2} leva", result);
            }
        }
    }
}
