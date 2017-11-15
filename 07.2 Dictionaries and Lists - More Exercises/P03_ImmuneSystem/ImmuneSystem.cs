using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_ImmuneSystem
{
    public class ImmuneSystem
    {
        public static void Main()
        {

           var health = int.Parse(Console.ReadLine());

            var initialHelth = health;

            var minutesTime = 0;
            var secondsTime = 0;
            var viruses = new List<string>();

            for (int i = 0; ; i++)
            {
                int vPower = 0;
                minutesTime = 0;
                secondsTime = 0;

                var virus = Console.ReadLine();
                

                if (virus == "end")
                {
                    Console.WriteLine($"Final Health: {health}");
                    break;
                }

                foreach (var item in virus)
                {
                    vPower += (char)item;
                }
                    vPower = vPower / 3;

                var defeatTime = 0;

                if (viruses.Contains(virus))
                {
                    defeatTime = vPower * virus.Length / 3;
                    health -= defeatTime;
                    minutesTime = (int)(defeatTime / 60);
                    secondsTime = defeatTime % 60;


                }
                else
                {
                    defeatTime = vPower * virus.Length;
                    health -= defeatTime;
                    minutesTime = (int)(defeatTime / 60);
                    secondsTime = defeatTime % 60;
                }

                if (!viruses.Contains(virus))
                {
                    viruses.Add(virus);
                }

                if (health < 0)
                {
                    Console.WriteLine($"Virus {virus}: {vPower} => {defeatTime} seconds");
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }
                else
                {
                    Console.WriteLine($"Virus {virus}: {vPower} => {defeatTime} seconds");
                    Console.WriteLine($"{virus} defeated in {minutesTime}m {secondsTime}s.");
                    Console.WriteLine($"Remaining health: {health}");
                }

                health = (int)(health + (health * 0.2));

                if (health > initialHelth)
                {
                    health = initialHelth;
                }


            }


        }
}
}
