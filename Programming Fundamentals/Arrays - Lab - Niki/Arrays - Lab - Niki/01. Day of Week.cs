using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays___Lab___Niki
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Satruday", "Sunday" };


            var nums = int.Parse(Console.ReadLine());

            if (nums >= 1 && nums <= 7)
            {
                Console.WriteLine(days[nums - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }


        }
    }
}
