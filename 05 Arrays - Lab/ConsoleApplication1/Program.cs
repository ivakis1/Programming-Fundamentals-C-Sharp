using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var num = double.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * num;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
