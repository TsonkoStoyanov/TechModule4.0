using System;

namespace P15_RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            for (int current = 2; current <= range; current++)
            {
                bool isPrimeNumber = true;

                for (int divisor = 2; divisor < current; divisor++)
                {
                    if (current % divisor == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }

                Console.WriteLine("{0} -> {1}", current, isPrimeNumber ? "true" : "false");

            }
        }
    }
}
