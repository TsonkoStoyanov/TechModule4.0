using System;

namespace P01_CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int minLength = Math.Min(input[0].Length, input[1].Length);

            long result = 0;

            for (int i = 0; i < minLength; i++)
            {
                int firstChar = input[0][i];
                int secondChar = input[1][i];

                result += firstChar * secondChar;
            }

            if (input[0].Length < input[1].Length)
            {
                int startIndex =input[0].Length;

                for (int i = startIndex; i < input[1].Length; i++)
                {
                    result += input[1][i];
                }
            }
            else if (input[0].Length > input[1].Length)
            {
                int startIndex =input[1].Length;

                for (int i = startIndex; i < input[0].Length; i++)
                {
                    result += input[0][i];
                }
            }

            Console.WriteLine(result);

        }
    }
}
