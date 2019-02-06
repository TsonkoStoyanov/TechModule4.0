using System;
using System.Runtime.CompilerServices;

namespace P14_FloatingEquality
{
    class Program
    {
        private static double eps = 0.000001;

        static void Main(string[] args)
        {
            double numberA = Double.Parse(Console.ReadLine());
            double numberB = Double.Parse(Console.ReadLine());


            double difrence = Math.Abs(numberA - numberB);

            if (difrence < eps)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
