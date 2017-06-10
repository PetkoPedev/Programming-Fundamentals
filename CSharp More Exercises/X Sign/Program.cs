using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int spaces = n - 2;
            for (int i = 0; i < n / 2; i++, spaces -= 2)
            {
                Console.WriteLine(new string(' ', i) + "x" + new string(' ', spaces) + "x");
            }
            Console.WriteLine(new string(' ', n / 2) + "x");
            spaces = 1;
            for (int i = n / 2; i > 0; i--, spaces += 2)
            {
                Console.WriteLine(new string(' ', i - 1) + "x" + new string(' ', spaces) + "x");
            }

        }
    }
}
