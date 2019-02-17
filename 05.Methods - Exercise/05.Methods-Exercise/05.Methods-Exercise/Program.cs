using System;

namespace P00_SmallestOf3Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());

            int secondNumber = int.Parse(Console.ReadLine());

            int thirdNumber = int.Parse(Console.ReadLine());

            SmallestOfThreeNumber(firstNumber, secondNumber, thirdNumber);
        }

        private static void SmallestOfThreeNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            int smallest = firstNumber;

            if (smallest > secondNumber)
            {
                smallest = secondNumber;
            }

            if (smallest > thirdNumber)
            {
                smallest = thirdNumber;
            }

            Console.WriteLine(smallest);
        }
    }
}
