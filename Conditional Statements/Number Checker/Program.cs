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
            try
            {
                var n = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
