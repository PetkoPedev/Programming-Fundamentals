using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());

            double studioperNight = 0;
            double doubleperNight = 0;
            double suiteperNight = 0;

            switch(month)
            {
                case "may":
                case "october":
                    studioperNight = 50;
                    doubleperNight = 65;
                    suiteperNight = 75;
                    if (nights > 7)
                    {
                        studioperNight *= 0.95;
                    }
                    break;
                case "june":
                case "september":
                    studioperNight = 60;
                    doubleperNight = 72;
                    suiteperNight = 82;
                    if (nights > 14)
                    {
                        doubleperNight *= 0.90;
                    }
                    break;
                case "july":
                case "august":
                case "december":
                    studioperNight = 68;
                    doubleperNight = 77;
                    suiteperNight = 89;
                    if (nights > 14)
                    {
                        suiteperNight *= 0.85;
                    }
                    break;
            }

            var totalStudioPrice = studioperNight * nights;
            var totalDoublePrice = doubleperNight * nights;
            var totalSuitePrice = suiteperNight * nights;

            if ((month == "september" || month == "october") && nights > 7)
            {
                totalStudioPrice -= studioperNight;
            }
            Console.WriteLine("Studio: {0:f2} lv.", totalStudioPrice);
            Console.WriteLine("Double: {0:f2} lv.", totalDoublePrice);
            Console.WriteLine("Suite: {0:f2} lv.", totalSuitePrice);
        }
    }
}
