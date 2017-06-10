using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var times = 1;
            while (times <= 10)
            {
                Console.WriteLine("{0} X {1} = {2}", n, times, n * times);
                times++;
            }
        }
    }
}
