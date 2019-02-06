using System;

namespace P13_FromLefttoTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            long result = 0;

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] inputArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                long left = long.Parse(inputArgs[0]);
                long right = long.Parse(inputArgs[1]);

                if (left >= right)
                {
                    result = CalculateSum(left);
                }
                else
                {
                    result = CalculateSum(right);
                }

                Console.WriteLine(Math.Abs(result));
            }
        }

        private static long CalculateSum(long number)
        {
            long result = 0;

            //while (number > 0)
            //{
            //    result += (int)(number % 10);
            //    number /= 10;
            //}

            int length = number.ToString().Length;
            for (int i = 0; i < length; i++)
            {
                result += number % 10;
                number /= 10;
            }

            return result;
        }
    }
}
