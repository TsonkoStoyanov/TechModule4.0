using System;
using System.Collections.Generic;
using System.Linq;

namespace P00_Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().Where(x => x != ' ').ToArray();

            Dictionary<char, int> counts = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (!counts.ContainsKey(currentChar))
                {
                    counts.Add(currentChar, 0);
                }

                counts[currentChar]++;
            }

            foreach (var count in counts)
            {
                Console.WriteLine($"{count.Key} -> {count.Value}");
            }
        }
    }
}
