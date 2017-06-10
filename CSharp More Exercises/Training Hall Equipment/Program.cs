using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());
            double subtotal = 0;
            for (int i = 0; i < numberOfItems; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());

                itemName += itemCount > 1 ? "s" : "";

                Console.WriteLine("Adding {0} {1} to cart.", itemCount, itemName);
                subtotal += (itemCount * itemPrice);
            }
            Console.WriteLine("Subtotal: ${0:f2}", subtotal);

            Console.WriteLine(
                budget >= subtotal ?
                $"Money left: ${budget - subtotal:F2}" :
                $"Not enough. We need ${subtotal - budget:F2} more."
                );
        }
    }
}
