using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var maximumSum = int.Parse(Console.ReadLine());

            var totalCombinations = 0;
            var sum = 0;
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    var number = (i * j) * 3;
                    sum += number;
                    totalCombinations++;

                    if(sum >= maximumSum)
                    {
                        Console.WriteLine("{0} combinations", totalCombinations);
                        Console.WriteLine("Sum: {0} >= {1}", sum, maximumSum);
                        return;
                    }
                }
            }
            Console.WriteLine("{0} combinations", totalCombinations);
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
