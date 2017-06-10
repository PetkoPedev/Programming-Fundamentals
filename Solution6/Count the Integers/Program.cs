using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            while (true)
            {
                try
                {
                    var n = int.Parse(Console.ReadLine());
                    counter++;
                }
                catch (Exception)
                {
                    Console.WriteLine(counter);
                    return;
                }

            }
        }
    }
}
