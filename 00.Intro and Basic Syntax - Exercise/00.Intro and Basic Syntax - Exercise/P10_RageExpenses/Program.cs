using System;

namespace P10_RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());

            decimal headsetPrice = decimal.Parse(Console.ReadLine());

            decimal mousePrice = decimal.Parse(Console.ReadLine());

            decimal keyboardPrice = decimal.Parse(Console.ReadLine());

            decimal displayPrice = decimal.Parse(Console.ReadLine());

            decimal totalPrice = 0;

            for (int i = 1; i <= lostGameCount; i++)
            {
                if (i % 2 == 0)
                {
                    totalPrice += headsetPrice;
                }

                if (i % 3 == 0)
                {
                    totalPrice += mousePrice;
                }

                if (i % 6 == 0)
                {
                    totalPrice += keyboardPrice;
                }

                if (i % 12 == 0)
                {
                    totalPrice += displayPrice;
                }

            }

            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
        }
    }
}
