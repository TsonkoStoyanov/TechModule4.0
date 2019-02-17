using System;

namespace P02_CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());

            char second = char.Parse(Console.ReadLine());

            PrintCharacters(first, second);
        }

        private static void PrintCharacters(char first, char second)
        {
            for (int i = Math.Min(first, second) + 1; i < Math.Max(first, second); i++)
            {
                Console.Write((char)i + " ");
            }

            Console.WriteLine();
        }
    }
}
