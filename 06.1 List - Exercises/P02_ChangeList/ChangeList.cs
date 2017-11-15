namespace P02_ChangeList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ChangeList
    {
       public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; ; i++)
            {
                var command = Console.ReadLine().Split().ToArray();

                if (command[0] == "Delete")
                {
                    var deleteNumbers = int.Parse(command[1]);

                    input.RemoveAll(x => x == deleteNumbers);
                }
                else if (command[0] == "Insert")
                {
                    input.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }

                if (command[0] == "Odd")
                {                   
                    Console.WriteLine(string.Join(" ", input.Where(x => x % 2 != 0)));
                    return;
                }
                else if (command[0] == "Even")
                {
                    Console.WriteLine(string.Join(" ", input.Where(x => x % 2 == 0)));
                    return;

                }

            }
        }
    }
}
