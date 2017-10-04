namespace P13_DecryptingMessages
{
    using System;

   public class DecryptingMessages
    {
       public static void Main()
        {
            var key = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            var message = new char[n];

            for (int i = 0; i < n; i++)
            {
                char[] symbol = Console.ReadLine().ToCharArray();

                message[i] = (char)(symbol[0] + key);
                
            }

            Console.WriteLine(string.Join("", message));
        }
    }
}
