using System;

namespace P02_DivisionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] divInts = new[] { 10, 7, 6, 3, 2 };
            int number = int.Parse(Console.ReadLine());
            bool isNumberDiv = false;
            string result = string.Empty;

            foreach (var divInt in divInts)
            {
                if (number % divInt == 0)
                {
                    result = $"The number is divisible by {divInt}";
                    isNumberDiv = true;
                    break;
                }
            }

            Console.WriteLine(isNumberDiv ? result : "Not divisible");

        }
    }
}
