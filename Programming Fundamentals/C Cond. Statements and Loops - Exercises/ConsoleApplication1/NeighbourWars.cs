namespace ConsoleApplication1
{
    using System;

    public class NeighbourWars
    {
       public static void Main()
        {
            var peshosDamage = int.Parse(Console.ReadLine());
            var goshosDamage = int.Parse(Console.ReadLine());

            var peshosHealth = 100;
            var goshosHealth = 100;

            if (peshosDamage == 0 || goshosDamage == 0)
            {
                Console.WriteLine("Pesho won in 1th round.");
                return;
            }     

            for (int i = 1; ; i++)
            {
                if (i % 2 != 0)
                {
                    if (peshosHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {i-1}th round.");
                        break;
                    }

                    goshosHealth -= peshosDamage;

                    if (goshosHealth > 0 )
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshosHealth} health.");
                    }
                    
                }
                else if (i % 2 == 0)
                {
                    if (goshosHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {i-1}th round.");
                        break;
                    }

                    peshosHealth -= goshosDamage;
                    if (peshosHealth > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshosHealth} health.");
                    }
                }
                if (i % 3 == 0 && goshosHealth > 0 && peshosHealth > 0)
                {
                    peshosHealth += 10;
                    goshosHealth += 10;
                }
                                             
            }
        
        }
    }
}
