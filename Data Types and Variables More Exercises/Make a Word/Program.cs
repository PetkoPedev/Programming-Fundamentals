using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string word = String.Empty;
            for (int i = 0; i < n; i++)
            {
                char tempChar = char.Parse(Console.ReadLine());
                word += tempChar;
            }
            Console.WriteLine("The word is: " + word);
        }
    }
}
