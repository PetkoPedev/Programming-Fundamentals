using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string metric = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());
            double convertedValue = 0;
            switch(metric)
            {
                case "miles":
                    convertedValue = value * 1.6;
                    Console.WriteLine("{0} {1} = {2:F2} kilometers", value, metric, convertedValue);
                    break;
                case "inches":
                    convertedValue = value * 2.54;
                    Console.WriteLine("{0} {1} = {2:F2} centimeters", value, metric, convertedValue);
                    break;
                case "feet":
                    convertedValue = value * 30;
                    Console.WriteLine("{0} {1} = {2:F2} centimeters", value, metric, convertedValue);
                    break;
                case "yards":
                    convertedValue = value * 0.91;
                    Console.WriteLine("{0} {1} = {2:F2} meters", value, metric, convertedValue);
                    break;
                case "gallons":
                    convertedValue = value * 3.8;
                    Console.WriteLine("{0} {1} = {2:F2} liters", value, metric, convertedValue);
                    break;
            }
        }
    }
}
