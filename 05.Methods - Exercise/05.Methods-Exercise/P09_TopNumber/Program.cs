using System;

namespace P09_TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            TopNumber(number);
        }

        private static void TopNumber(int number)
        {
            for (int i = 8; i <= number; i++)
            {
                if (!IsSumOfDigitDivisibleByEigth(i))
                {
                    continue;
                }

                if (!IsOneDigitOdd(i))
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }

        private static bool IsOneDigitOdd(int number)
        {
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    return true;
                }
                number /= 10;
            }

            return false;
        }

        private static bool IsSumOfDigitDivisibleByEigth(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                sum += lastDigit;
                number /= 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
