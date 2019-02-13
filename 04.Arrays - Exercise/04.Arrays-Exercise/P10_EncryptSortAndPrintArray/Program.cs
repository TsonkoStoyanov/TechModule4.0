using System;
using System.Collections.Generic;
using System.Linq;

namespace P10_EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfInput = int.Parse(Console.ReadLine());

            int[] numbers = new int[numberOfInput];

            char[] vowels = new char[] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < numberOfInput; i++)
            {
                int sum = 0;

                char[] input = Console.ReadLine().ToCharArray();

                int length = input.Length;

                for (int j = 0; j < length; j++)
                {
                    char current = input[j];
                    if (vowels.Contains(current))
                    {
                        sum += current * length;
                    }
                    else
                    {
                        sum += current / length;
                    }
                }

                numbers[i] = sum;
            }

           int[] ordered = numbers.OrderBy(x => x).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, ordered));
        }
    }
}
