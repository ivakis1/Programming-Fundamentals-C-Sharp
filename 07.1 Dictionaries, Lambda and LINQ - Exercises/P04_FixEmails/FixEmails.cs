namespace P04_FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class FixEmails
    {
       public static void Main()
        {
            var emailsList = new Dictionary<string, string>();

            for (int i = 0; ; i++)
            {
                var name = Console.ReadLine();

                if (name == "stop")
                {
                    foreach (var item in emailsList)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                    break;
                }

                var email = Console.ReadLine();

                var domainCheck = email.Substring(email.Length - 2);

                //var lastElementCheck = email.Reverse().Take(2).ToList();

                //lastElementCheck.Reverse();

                //if (lastElementCheck[0] == 'u' && (lastElementCheck[1] == 'k' || lastElementCheck[1] == 's') )
                //{
                //    continue;
                //}
                if(domainCheck == "uk" || domainCheck == "us")
                {
                    continue;
                }
                else
                {
                    emailsList[name] = email;

                }

            }
        }
    }
}
