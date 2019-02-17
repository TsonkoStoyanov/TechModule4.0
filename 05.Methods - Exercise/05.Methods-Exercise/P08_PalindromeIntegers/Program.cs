using System;

namespace P08_PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                Console.WriteLine(IsPalindromeNumber(input).ToString().ToLower());
                input = Console.ReadLine();

            }
        }

        private static bool IsPalindromeNumber(string number)
        {
            for (int i = 0; i < number.Length / 2; i++)
            {
                if (!number[i].Equals(number[number.Length - 1 - i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
