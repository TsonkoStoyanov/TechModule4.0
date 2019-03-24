using System;

namespace P01_AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            long totalSum = 0;

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > start && input[i] < end)
                {
                    totalSum += input[i];
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}
