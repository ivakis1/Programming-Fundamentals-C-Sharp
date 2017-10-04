namespace P06_Heists
{
    using System;
    using System.Linq;

    public class Heists
    {
       public static void Main()
        {
            var goodiesPrices = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var expences = 0;
            var earnings = 0;

            for (int i = 0; ; i++)
            {
                var input = Console.ReadLine().Split().ToArray();

                if (input[0] == "Jail" && input[1] == "Time")
                {
                    break;
                }


                foreach (var item in input[0])
                {
                    if (item == '$')
                    {
                        earnings += goodiesPrices[1];
                    }
                    else if (item == '%')
                    {
                        earnings += goodiesPrices[0];
                    }
                }
                    
                
                expences += int.Parse(input[1]);
            }
          
            if (earnings >= expences)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {earnings - expences}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {expences - earnings}.");
            }
        }
    }
}
