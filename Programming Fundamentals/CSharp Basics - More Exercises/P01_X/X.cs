namespace P01_X
{
    using System;

   public class X
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var spaces = -1;

            for (int i = 0; i < n / 2; i++)
            {
                var body = new string(' ', i) + "x" + new string(' ', n - 2 - 2 * i) + "x" + new string(' ', i);

                spaces++;
                Console.WriteLine(body);
            }

            var middlePart = new string(' ', n / 2) + "x" + new string(' ', n / 2);
            Console.WriteLine(middlePart);

            for (int i = 0; i < n / 2; i++)
            {
                var bottom = new string(' ', spaces - i) + "x" + new string(' ', 1 + 2 * i) + "x" + new string(' ', spaces - i);

                Console.WriteLine(bottom);
            }
        }
    }
}
