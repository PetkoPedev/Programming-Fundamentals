using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hex
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a hexadecimal value out of range of the Integer type.
            string value = Convert.ToString(Console.ReadLine());
            // Convert it back to a number.
            int number = Convert.ToInt32(value, 16);
            Console.WriteLine("{0}", number.ToString());
        }
    }
}
