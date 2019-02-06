using System;

namespace P14_ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length / 2; i++)
            {
                char temp = input[i];

                input[i] = input[input.Length - 1 - i];
                input[input.Length - 1 - i] = temp;
            }

            Console.WriteLine(input);
        }
    }
}
