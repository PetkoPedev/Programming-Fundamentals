using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var startIndex = int.Parse(Console.ReadLine());
            var endIndex = int.Parse(Console.ReadLine());

            for (char @char = (char)startIndex; @char <= endIndex; @char++)
            {
                Console.Write(@char + " ");
            }
        }
    }
}
