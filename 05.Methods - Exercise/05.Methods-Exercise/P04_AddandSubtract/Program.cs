using System;
using System.Diagnostics.CodeAnalysis;

namespace P04_AddandSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());

            int second = int.Parse(Console.ReadLine());

            int third = int.Parse(Console.ReadLine());

            int sum = Sum(first, second);

            int result = Subtract(sum, third);

            Console.WriteLine(result);
        }

        private static int Subtract(int sum, int third)
        {
            return sum - third;
        }

        private static int Sum(int first, int second)
        {
            return first + second;
        }
    }
}
