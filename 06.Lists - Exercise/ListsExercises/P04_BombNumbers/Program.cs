using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] bombs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombNumber = bombs[0];
            int bombPower = bombs[1];

            while (numbers.Contains(bombNumber))
            {
                int bombIndex = numbers.IndexOf(bombNumber);

                int startIndex = Math.Max(0, bombIndex - bombPower);
                int endIndex = Math.Min(numbers.Count - 1, bombIndex + bombPower);

                numbers.RemoveRange(startIndex, endIndex - startIndex + 1);

            }

           Console.WriteLine(numbers.Sum());
        }


    }
}
