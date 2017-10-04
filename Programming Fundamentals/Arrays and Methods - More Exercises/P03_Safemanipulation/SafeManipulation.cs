namespace P03_Safemanipulation
{
    using System;
    using System.Linq;

    public class SafeManipulation
    {
      public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
        

            for (int i = 0; ; i++)
            {
                var command = Console.ReadLine().Split(' ').ToArray();

                if (command[0] == "END")
                {
                    break;
                }
                else if (command[0] == "Reverse")
                {
                    Array.Reverse(input);
                }
                else if (command[0] == "Distinct")
                {
                    input = input.Distinct().ToArray();
                }
                else if (command[0] == "Replace")               
                {
                    int replace = -1;
                        int.TryParse(command[1], out replace);
                    
                    if ( replace >= input.Length || replace < 0)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;                     
                    }

                    input[replace] = command[2];
                }
                else
                {
                        Console.WriteLine("Invalid input!");
                }
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
