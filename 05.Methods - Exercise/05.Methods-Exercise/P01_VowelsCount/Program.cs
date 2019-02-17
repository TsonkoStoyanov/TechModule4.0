using System;
using System.Linq;

namespace P01_VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] vowels = new char[] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };

            string input = Console.ReadLine();

            int count = CountVowels(input, vowels);

            Console.WriteLine(count);
        }

        private static int CountVowels(string input, char[] vowels)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
