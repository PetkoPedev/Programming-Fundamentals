﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var current = 1;
            var sum = 0;
            while (n > 0)
            {
                Console.WriteLine(current);
                sum += current;
                n--;
                current += 2;
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
