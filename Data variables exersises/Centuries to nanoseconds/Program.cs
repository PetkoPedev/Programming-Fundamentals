using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            ulong years = (ulong)(centuries * 100);
            ulong days = (ulong)(years * 365.2422);
            ulong hours = 24 * days;
            ulong minutes = 60 * hours;
            ulong seconds = 60 * minutes;
            ulong miliseconds = 1000 * seconds;
            decimal microseconds = 1000 * miliseconds;
            decimal nanoseconds = 1000 * microseconds;
            
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
