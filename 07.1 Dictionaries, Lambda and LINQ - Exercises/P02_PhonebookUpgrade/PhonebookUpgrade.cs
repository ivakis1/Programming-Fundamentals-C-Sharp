namespace P02_Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PhonebbokUpgrade
    {
        public static void Main()
        {
            var phonebook = new SortedDictionary<string, string>();

            for (int i = 0; ; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                if (input[0] == "END")
                {
                    break;
                }
                else if (input[0] == "A")
                {
                    phonebook[input[1]] = input[2];
                }
                else if (input[0] == "S")
                {
                    if (phonebook.ContainsKey(input[1]))
                    {
                        foreach (var item in phonebook)
                        {
                            if (item.Key == input[1])
                            {
                                Console.WriteLine(item.Key + " -> " + item.Value);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
                else if (input[0] == "ListAll")
                {
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine(item.Key + " -> " + item.Value);
                    }
                }
            }
        }
    }
}
