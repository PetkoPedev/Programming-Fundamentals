﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long totalSum = 0L;

            for (int i = 0; i < n; i++)
            {
                char tempChar = char.Parse(Console.ReadLine());
                totalSum += tempChar;
            }
            Console.WriteLine("The sum equals: " + totalSum);
        }
    }
}
