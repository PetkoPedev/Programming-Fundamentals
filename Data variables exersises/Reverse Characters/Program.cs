using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            char ch3 = char.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{2}", ch3, ch2, ch1);
        }
    }
}
