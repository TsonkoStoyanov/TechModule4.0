using System;

namespace P07_FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());

            int secondNumber = int.Parse(Console.ReadLine());

            long firstFactorial = Factorial(firstNumber);

            long secondFactorial = Factorial(secondNumber);

            double result = firstFactorial /(double)secondFactorial;

            Console.WriteLine($"{result:f2}");

        }

        private static long Factorial(int number)
        {
            long result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
