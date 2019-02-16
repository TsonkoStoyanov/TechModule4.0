using System;

namespace P12_RecursiveFibonacci
{
    class Program
    {
        private static int[] array = new int[51];

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            
            Console.WriteLine(Fibonacci(n));
        }

        static int Fibonacci(int n)  
        {
            if (n < 2)
            {
                return n;
            }

            if (array[n] != 0 )
            {

                return array[n];
            }

            array[n] = Fibonacci(n - 1) + Fibonacci(n - 2);

            return array[n];
        }
    }
}
