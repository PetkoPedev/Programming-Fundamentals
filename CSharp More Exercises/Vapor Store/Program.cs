using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double spentMoney = 0;
            
            while(balance > 0)
            {
                double gamePrice = 0;
                string game = Console.ReadLine();
                switch (game)
                {
                    case "CS: OG":
                        gamePrice = 15.99;
                        //balance -= gamePrice;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        //balance -= gamePrice;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        //balance -= gamePrice;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        //balance -= gamePrice;
                        break;
                    case "OutFall 4":
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        //balance -= gamePrice;
                        break;
                    case "Game Time":
                        Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}", spentMoney, balance);
                        return;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }
                if(balance >= gamePrice)
                {
                    Console.WriteLine("Bought {0}", game);
                    balance -= gamePrice;
                    spentMoney += gamePrice;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            Console.WriteLine("Out of money!");
        }
    }
}
