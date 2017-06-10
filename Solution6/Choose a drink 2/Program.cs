using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_drink_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();//.ToLower();
            var quantity = double.Parse(Console.ReadLine());
            double drinkType = 0;
            if (profession == "Athlete")
            {
                drinkType = 0.70;
                Console.WriteLine("The {0} has to pay {1:f2}.", profession, quantity * drinkType);
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                drinkType = 1.00;
                Console.WriteLine("The {0} has to pay {1:f2}.", profession, quantity * drinkType);
            }
            else if (profession == "SoftUni Student")
            {
                drinkType = 1.70;
                Console.WriteLine("The {0} has to pay {1:f2}.", profession, quantity * drinkType);
            }
            else
            {
                drinkType = 1.20;
                Console.WriteLine("The {0} has to pay {1:f2}.", profession, quantity * drinkType);
            }
        }
    }
}
