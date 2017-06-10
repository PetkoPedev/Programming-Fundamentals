using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string message = "";
            while (n > 0)
            {
                message += ((char)(char.Parse(Console.ReadLine()) + key)).ToString();
                n--;
            }

            Console.WriteLine(message);
        }
    }
}
