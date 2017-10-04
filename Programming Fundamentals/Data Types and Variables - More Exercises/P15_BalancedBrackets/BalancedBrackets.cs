namespace P15_BalancedBrackets
{
    using System;

   public class BalancedBrackets
    {
       public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            bool isBalanced = false;
            bool unBalanced = false;
            bool openingBracked = false;
            bool closingBracked = false;
            bool brackedMistake = false;
            

            for (int i = 0; i < n; i++)
            {
                var text = Console.ReadLine();

                if (text[0]  == '(')
                {
                    if (openingBracked == true && text[0] == '(')
                    {
                        brackedMistake = true;
                        break;
                    }
                    openingBracked = true;
                    closingBracked = false;
                    isBalanced = false;
                }
                if (openingBracked == false && text[0] == ')')
                {
                    brackedMistake = true;
                }
                if (openingBracked == true && text[0] == ')')
                {
                    isBalanced = true;
                    openingBracked = false;
                    closingBracked = true;
                    unBalanced = false;
                }
                      
            }

            if (brackedMistake || openingBracked)
            {
                Console.WriteLine("UNBALANCED");
                return;
            }else if (unBalanced) 
            {
                Console.WriteLine("UNBALANCED");             
            }
            else if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("BALANCED");
            }
            
           
        }
    }
}
