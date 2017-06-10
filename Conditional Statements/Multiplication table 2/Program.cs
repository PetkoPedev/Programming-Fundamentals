using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_table_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("{0} X {1} = {2}", n, times, n * times);
                times++;
            }
            while (times <= 10);
        }
    }
}
