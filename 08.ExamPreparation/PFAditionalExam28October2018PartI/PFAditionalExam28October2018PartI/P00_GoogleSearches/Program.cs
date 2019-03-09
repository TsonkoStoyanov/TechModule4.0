using System;

namespace P00_GoogleSearches
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalDays = int.Parse(Console.ReadLine());

            int numberOfUsers = int.Parse(Console.ReadLine());

            decimal moneyPerSearch = decimal.Parse(Console.ReadLine());

            decimal totalMoney = 0;

            for (int i = 1; i <= numberOfUsers; i++)
            {
                int words = int.Parse(Console.ReadLine());

                if (words > 5)
                {
                    continue;
                }

                decimal currentSearchMoney = moneyPerSearch;

                if (words == 1)
                {
                    currentSearchMoney = 2 * currentSearchMoney;
                }

                if (i % 3 == 0)
                {
                    currentSearchMoney = 3 * currentSearchMoney;
                }

                totalMoney += currentSearchMoney;
            }

            Console.WriteLine($"Total money earned for {totalDays} days: {totalDays * totalMoney:f2}");
        }
    }
}
