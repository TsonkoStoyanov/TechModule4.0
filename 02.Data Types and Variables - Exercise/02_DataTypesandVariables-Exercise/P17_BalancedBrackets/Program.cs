using System;

namespace P17_BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            bool isBalanced = true;
          
            int openedBracket = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    openedBracket++;
                }
                else if (input == ")" && openedBracket > 0)
                {
                    openedBracket--;
                }
                else if (input == ")" && openedBracket <= 0)
                {
                    isBalanced = false;
                }
                               
            }

            if (isBalanced && openedBracket == 0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }

        }
    }
}
