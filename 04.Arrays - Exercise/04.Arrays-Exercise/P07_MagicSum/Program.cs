using System;
using System.Linq;

namespace P07_MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                if (number > sum)
                {
                    continue;
                }

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] > sum )
                    {
                        continue;
                    }

                    if (number + numbers[j] == sum)
                    {
                        Console.WriteLine($"{number} {numbers[j]}");
                    }
                }
            }
        }
    }
}
