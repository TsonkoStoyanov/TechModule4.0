using System;

namespace P00_PartyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());

            int days = int.Parse(Console.ReadLine());

            int coins = 0;

            int food = 0;

            int water = 0;

            int monsterSlay = 0;

            for (int i = 1; i <= days; i++)
            {
                coins += 50;

                if (i % 10 == 0)
                {
                    partySize -= 2;
                }

                if (i % 15 == 0)
                {
                    partySize += 5;
                    water = partySize * 2;
                    coins -= water;
                }

                if (i % 3 == 0)
                {
                    water = partySize * 3;
                    coins -= water;
                }

                if (i % 5 == 0)
                {
                    monsterSlay = partySize * 20;
                    coins += monsterSlay;
                }

                food = 2 * partySize;
                coins -= food;

            }

            Console.WriteLine($"{partySize} companions received {coins / partySize} coins each.");
        }
    }
}
