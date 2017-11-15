using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11_Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var metres = float.Parse(Console.ReadLine());
            var hours = float.Parse(Console.ReadLine());
            var minutes = float.Parse(Console.ReadLine());
            var seconds = float.Parse(Console.ReadLine());

            float totalSeconds = hours * 3600 + minutes * 60 + seconds;
            float totalHours = totalSeconds / 3600;


            float mps = metres / totalSeconds;
            float kmh = (metres / 1000) / totalHours;
            float mph = metres / 1609 / totalHours;

            Console.WriteLine(mps);
            Console.WriteLine(kmh);
            Console.WriteLine(mph);
                             
        }
    }
}