using System;
using System.Linq;

namespace P10_LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (var word in words)
            {
                char firstLetter = word[0];
                char lastLetter = word[word.Length - 1];
                int count = word.Length - 2;

                var digit = double.Parse(word.Substring(1, count));

                if (char.IsUpper(firstLetter))
                {
                    digit /= (double)(firstLetter - 64);
                }
                else
                {
                    digit *= (firstLetter - 96);
                }

                if (char.IsUpper(lastLetter))
                {
                    digit -= (lastLetter - 64);
                }
                else
                {
                    digit += (lastLetter - 96);
                }

                sum += digit;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
