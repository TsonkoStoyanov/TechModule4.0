using System;

namespace P06_StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberTocompare = number;
            int sum = 0;

            while (number != 0)
            {
                int fact = 1;
                int lastDigit = number % 10;

                for (int i = 1; i <= lastDigit; i++)
                {
                    fact *= i;
                }

                sum += fact;
                number /= 10;
            }

            if (numberTocompare == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
