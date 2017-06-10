using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 0;
            

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    sum = i + j;
                    count++;
                    if (sum == magicNumber)
                    {
                        Console.WriteLine("Number found! {0} + {1} = {2}", j, i, magicNumber);
                        return;
                    }
                }
            }
            
            Console.WriteLine("{0} combinations - neither equals {1}", count, magicNumber);
        }
    }
}
