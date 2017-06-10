﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeofDay = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            if (age >= 0 && age <= 18)
            {
                if (typeofDay == "weekday")
                    Console.WriteLine("12$");
                else if (typeofDay == "weekend")
                    Console.WriteLine("15$");
                else if (typeofDay == "holiday")
                    Console.WriteLine("5$");
            }
            else if (age > 18 && age <= 64)
            {
                if (typeofDay == "weekday")
                    Console.WriteLine("18$");
                else if (typeofDay == "weekend")
                    Console.WriteLine("20$");
                else if (typeofDay == "holiday")
                    Console.WriteLine("12$");
            }
            else if (age > 64 && age <= 122)
            {
                if (typeofDay == "weekday")
                    Console.WriteLine("12$");
                else if (typeofDay == "weekend")
                    Console.WriteLine("15$");
                else if (typeofDay == "holiday")
                    Console.WriteLine("10$");
            }
            else
                Console.WriteLine("Error!");
        }
    }
}
