using System;

namespace P05_MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleCharacter(input);
        }

        private static void PrintMiddleCharacter(string input)
        {

            int index = input.Length / 2;

            if (input.Length % 2 == 0)
            {
                Console.WriteLine($"{input[index - 1]}{input[index]}");
            }
            else
            {
                Console.WriteLine(input[index]);
            }
        }
    }
}
