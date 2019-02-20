using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ExceptionServices;

namespace P14_TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            List<BigInteger> numbers = Tribonacci(number);

            Console.WriteLine(String.Join(" ", numbers.Take(number)));

        }

        private static List<BigInteger> Tribonacci(int number)
        {
            List<BigInteger> numbers = new List<BigInteger>();

            BigInteger first = 1;
            BigInteger second = 1;
            BigInteger third = 2;

            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(2);

            while (number > 2)
            {
                BigInteger current = first + second + third;
                numbers.Add(current);
                first = second;
                second = third;
                third = current;
                number--;
            }

            return numbers;
        }
    }
}
