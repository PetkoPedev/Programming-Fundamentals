using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();

            long num;
            var isInterger = long.TryParse(number, out num);

            if (isInterger)
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
