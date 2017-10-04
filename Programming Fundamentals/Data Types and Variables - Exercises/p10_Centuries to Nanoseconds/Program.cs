using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10_Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
             int centuries = int.Parse(Console.ReadLine());

            
             int years = centuries * 100;
             int days = (int)(years * 365.2422);
            BigInteger hours = days * 24;

            BigInteger minutes = (hours * 60);

            BigInteger seconds = (minutes * 60);

            BigInteger miliseconds = (seconds * 1000);

            BigInteger microseconds = miliseconds * 1000;

            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
            



        }
    }
}
