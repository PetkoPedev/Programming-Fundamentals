﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if(a<b)
            {
                for (int i = a; i <= b; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if(a>b)
            {
                for (int i = b; i <= a; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if(a==b)
            {
                Console.WriteLine(" ");
            }
        }
    }
}
