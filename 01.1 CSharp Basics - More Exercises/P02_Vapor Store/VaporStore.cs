namespace P02_Vapor_Store
{
    using System;

   public class VaporStore
    {
       public static void Main()
        {
            var money = double.Parse(Console.ReadLine());
            var totalSpent = money;

            var OutFall4 = 39.99;
            var CSOG = 15.99;
            var ZplinterZell = 19.99;
            var Honored2 = 59.99;
            var RoverWatch = 29.99;
            var RoverWatchOriginsEdition = 39.99;

            while (money > 0)
            {
                var game = Console.ReadLine();

                if (game == "OutFall 4")
                {
                    if (money < OutFall4)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    money = money - OutFall4;
                    Console.WriteLine("Bought OutFall 4");
                }
                else if (game == "CS: OG")
                {
                    if (money < CSOG)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    money -= CSOG;
                    Console.WriteLine("Bought CS: OG");
                }
                else if (game == "Zplinter Zell")
                {
                    if (money < ZplinterZell)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    money -= ZplinterZell;
                    Console.WriteLine("Bought Zplinter Zell");
                }
                else if (game == "Honored 2")
                {
                    if (money < Honored2)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    money -= Honored2;
                    Console.WriteLine("Bought Honored 2");
                }
                else if (game == "RoverWatch")
                {
                    if (money < RoverWatch)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    money -= RoverWatch;
                    Console.WriteLine("Bought RoverWatch");
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    if (money < RoverWatchOriginsEdition)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    money -= RoverWatchOriginsEdition;
                    Console.WriteLine("Bought RoverWatch Origins Edition");
                }
                else if (game == "Game Time")
                {
                    break;
                }
                else if (game != "OutFall 4" || game != "Bought OutFall 4" || game != "RoverWatch"
                    || game != "Bought Zplinter Zell" || game != "Honored 2" || game != "RoverWatch" || game != "Bought RoverWatch Origins Edition")
                {
                    Console.WriteLine("Not Found");
                }
                
            }

            if (money <= 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
           
            Console.WriteLine($"Total spent: ${totalSpent - money:F2}. Remaining: ${money:F2}");


        }
    }
}
