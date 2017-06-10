using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();

            double priceofRoom = 0;
            double discount = 0;
            double totalwithDiscount = 0;
            double totalPrice = 0;
            double priceofPackage = 0;
            double priceperPerson = 0;
            string hallName = null;
            if(group <= 50)
            {
                //small hall
                priceofRoom = 2500;
                hallName = "Small Hall";
                if(package == "normal")
                {
                    priceofPackage = 500;
                    totalPrice = priceofRoom + priceofPackage;
                    discount = totalPrice * 0.05;
                    totalwithDiscount = totalPrice - discount;
                    priceperPerson = totalwithDiscount / group;
                    Console.WriteLine("We can offer you the {0}", hallName);
                    Console.WriteLine("The price per person is {0:f2}$", priceperPerson);
                }
                else if(package == "gold")
                {
                    priceofPackage = 750;
                    totalPrice = priceofRoom + priceofPackage;
                    discount = totalPrice * 0.10;
                    totalwithDiscount = totalPrice - discount;
                    priceperPerson = totalwithDiscount / group;
                    Console.WriteLine("We can offer you the {0}", hallName);
                    Console.WriteLine("The price per person is {0:f2}$", priceperPerson);
                }
                else if(package == "platinum")
                {
                    priceofPackage = 1000;
                    totalPrice = priceofRoom + priceofPackage;
                    discount = totalPrice * 0.15;
                    totalwithDiscount = totalPrice - discount;
                    priceperPerson = totalwithDiscount / group;
                    Console.WriteLine("We can offer you the {0}", hallName);
                    Console.WriteLine("The price per person is {0:f2}$", priceperPerson);
                }
            }
            else if(group <= 100)
            {
                hallName = "Terrace";
                priceofRoom = 5000;
                if (package == "normal")
                {
                    priceofPackage = 500;
                    totalPrice = priceofRoom + priceofPackage;
                    discount = totalPrice * 0.05;
                    totalwithDiscount = totalPrice - discount;
                    priceperPerson = totalwithDiscount / group;
                    Console.WriteLine("We can offer you the {0}", hallName);
                    Console.WriteLine("The price per person is {0:f2}$", priceperPerson);
                }
                else if (package == "gold")
                {
                    priceofPackage = 750;
                    totalPrice = priceofRoom + priceofPackage;
                    discount = totalPrice * 0.10;
                    totalwithDiscount = totalPrice - discount;
                    priceperPerson = totalwithDiscount / group;
                    Console.WriteLine("We can offer you the {0}", hallName);
                    Console.WriteLine("The price per person is {0:f2}$", priceperPerson);
                }
                else if (package == "platinum")
                {
                    priceofPackage = 1000;
                    totalPrice = priceofRoom + priceofPackage;
                    discount = totalPrice * 0.15;
                    totalwithDiscount = totalPrice - discount;
                    priceperPerson = totalwithDiscount / group;
                    Console.WriteLine("We can offer you the {0}", hallName);
                    Console.WriteLine("The price per person is {0:f2}$", priceperPerson);
                }
            }
            else if(group <= 120)
            {
                hallName = "Great Hall";
                priceofRoom = 7500;
                if (package == "normal")
                {
                    priceofPackage = 500;
                    totalPrice = priceofRoom + priceofPackage;
                    discount = totalPrice * 0.05;
                    totalwithDiscount = totalPrice - discount;
                    priceperPerson = totalwithDiscount / group;
                    Console.WriteLine("We can offer you the {0}", hallName);
                    Console.WriteLine("The price per person is {0:f2}$", priceperPerson);
                }
                else if (package == "gold")
                {
                    priceofPackage = 750;
                    totalPrice = priceofRoom + priceofPackage;
                    discount = totalPrice * 0.10;
                    totalwithDiscount = totalPrice - discount;
                    priceperPerson = totalwithDiscount / group;
                    Console.WriteLine("We can offer you the {0}", hallName);
                    Console.WriteLine("The price per person is {0:f2}$", priceperPerson);
                }
                else if (package == "platinum")
                {
                    priceofPackage = 1000;
                    totalPrice = priceofRoom + priceofPackage;
                    discount = totalPrice * 0.15;
                    totalwithDiscount = totalPrice - discount;
                    priceperPerson = totalwithDiscount / group;
                    Console.WriteLine("We can offer you the {0}", hallName);
                    Console.WriteLine("The price per person is {0:f2}$", priceperPerson);
                }
            }
            else if (group > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            
        }
    }
}
