using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            long maxValue = 0L;

            switch (type)
            {
                case "sbyte":
                    maxValue = sbyte.MaxValue;
                    break;
                case "int":
                    maxValue = int.MaxValue;
                    break;
                case "long":
                    maxValue = long.MaxValue;
                    break;
            }
            int n = int.Parse(Console.ReadLine());
            long thiefsID = long.MinValue;
            for (int i = 0; i < n; i++)
            {
                long tempID = long.Parse(Console.ReadLine());
                if (tempID > thiefsID && tempID <= maxValue)
                {
                    thiefsID = tempID;
                }
            }
            double num = 0;
            if(thiefsID < 0)
            {
                num = sbyte.MinValue;
            }
            else
            {
                num = sbyte.MaxValue;
            }

            double years = Math.Ceiling(thiefsID / num);
            Console.WriteLine("Prisoner with id {0} is sentenced to {1} {2}",
                thiefsID,
                years,
                years > 1 ? "years" : "year");
        }
    }
}
