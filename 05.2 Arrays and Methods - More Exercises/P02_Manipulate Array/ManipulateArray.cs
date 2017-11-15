namespace P02_Manipulate_Array
{
    using System;
    using System.Linq;

    public class ManipulateArray
    {
       public static void Main()
        {
            var input = Console.ReadLine().Split(' ');

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(' ').ToArray();

                if (command[0] == "Reverse")
                {
                    Array.Reverse(input);
                }
                else if (command[0] == "Distinct")
                {
                    input = input.Distinct().ToArray();
                }
                else
                {
                    int replace = int.Parse(command[1]);

                    input[replace] = command[2];
                }
            }
            Console.WriteLine(string.Join(", ", input));
            
        }
    }
}
