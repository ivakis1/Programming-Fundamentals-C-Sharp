namespace P05_Word_in_Plural
{
    using System;
    using System.Collections;
    using System.Linq;

   public class WordInPlural
    {
       public static void Main()
        {
            var input = Console.ReadLine();
            char[] trim = { 'y' };

            if (input.EndsWith("y"))
            {
                string newString = input.TrimEnd(trim);
                Console.WriteLine(newString+"ies");

            }
            else if (input.EndsWith("o") || input.EndsWith("ch") || input.EndsWith("s") || input.EndsWith("sh") ||
                input.EndsWith("x") || input.EndsWith("z"))
            {
                Console.WriteLine(input + "es");
            }
            else
            {
                Console.WriteLine(input + "s");
            }

           
            
        }
    }
}
