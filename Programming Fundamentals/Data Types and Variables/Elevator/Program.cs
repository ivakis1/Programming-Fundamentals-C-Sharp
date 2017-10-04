using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            short persons = short.Parse(Console.ReadLine());
            short capasity = short.Parse(Console.ReadLine());

            int courses = (int) Math.Ceiling((double) persons / capasity);

            Console.WriteLine(courses);
        }
    }
}
