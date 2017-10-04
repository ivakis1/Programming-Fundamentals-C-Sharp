namespace P14_BoatSimulator
{
    using System;

   public class BoatSimulator
    {
       public static void Main()
        {
            var firstBoat = Console.ReadLine().ToCharArray();
            var secondBoat = Console.ReadLine().ToCharArray();

            var n = int.Parse(Console.ReadLine());

            var firstBoatMoves = 0;
            var secondBoatMoves = 0;


            for (int i = 1; i <= n; i++)
            {
                if (firstBoatMoves >= 50 || secondBoatMoves >= 50)
                {
                    break;
                }
                var line = Console.ReadLine();

               

                if (line ==  "UPGRADE")
                {
                    firstBoat[0] = (char)(firstBoat[0] + 3);
                    secondBoat[0] = (char)(secondBoat[0] + 3);
                    continue;
                }

                if (i % 2 != 0)
                {
                    firstBoatMoves += line.Length;
                }
                else if( i % 2 == 0)
                {
                    secondBoatMoves += line.Length;
                }

            }
            if (firstBoatMoves > secondBoatMoves)
            {
                Console.WriteLine(firstBoat[0]);
            }
            else
            {
                Console.WriteLine(secondBoat[0]);
            }
        }
    }
}
