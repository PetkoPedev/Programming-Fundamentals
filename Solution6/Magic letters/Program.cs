using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var lastLetter = char.Parse(Console.ReadLine());
            var invalidLetter = char.Parse(Console.ReadLine());

            for (char i = firstLetter; i <= lastLetter; i++)
            {
                if(i == invalidLetter)
                {
                    continue;
                }
                for (char j = firstLetter; j <= lastLetter; j++)
                {
                    if(j == invalidLetter)
                    {
                        continue;
                    }
                    for (char k = firstLetter; k <= lastLetter; k++)
                    {
                        if(k == invalidLetter)
                        {
                            continue;
                        }
                        Console.Write("{0}{1}{2} ", i, j, k);
                    }
                }
            }
        }
    }
}
