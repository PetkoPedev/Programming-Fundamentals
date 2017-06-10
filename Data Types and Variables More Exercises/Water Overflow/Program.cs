﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var capacity = 255;
            int initialCapacity = 0;

            for (int i = 1; i <= n; i++)
            {
                int quantities = int.Parse(Console.ReadLine());
                initialCapacity += quantities;
                if(initialCapacity > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    initialCapacity -= quantities;
                }
                //Console.WriteLine(initialCapacity);
            }
            Console.WriteLine(initialCapacity);
        }
    }
}
