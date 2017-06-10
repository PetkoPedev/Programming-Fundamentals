using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Convert.ToString(Console.ReadLine());
            bool number = Convert.ToBoolean(value);
            if(number)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
