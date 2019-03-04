using System;

namespace P01_BreadFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = 100;
            int coins = 100;

            int currentEnergy = initialEnergy;

            string[] input = Console.ReadLine().Split("|");

            bool isBankrupt = false;

            for (int i = 0; i < input.Length; i++)
            {
                string[] inputArgs = input[i].Split("-");

                string eventOrIngredient = inputArgs[0];
                int number = int.Parse(inputArgs[1]);

                if (eventOrIngredient == "rest")
                {
                    if (currentEnergy + number > 100)
                    {
                        int actualEnergy = initialEnergy - currentEnergy;

                        currentEnergy = initialEnergy;

                        Console.WriteLine($"You gained {actualEnergy} energy.");
                    }
                    else
                    {
                        currentEnergy += number;

                        Console.WriteLine($"You gained {number} energy.");
                    }

                    Console.WriteLine($"Current energy: {currentEnergy}.");
                }
                else if (eventOrIngredient == "order")
                {
                    ;

                    if (currentEnergy - 30 < 0)
                    {
                        Console.WriteLine($"You had to rest!");
                        currentEnergy += 50;
                    }
                    else
                    {
                        currentEnergy -= 30;
                        coins += number;
                        Console.WriteLine($"You earned {number} coins.");
                    }
                }
                else
                {
                    coins -= number;

                    if (coins <= 0)
                    {
                        isBankrupt = true;
                        Console.WriteLine($"Closed! Cannot afford {eventOrIngredient}.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You bought {eventOrIngredient}.");
                    }
                }
            }

            if (!isBankrupt)
            {
                Console.WriteLine($"Day completed!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Energy: {currentEnergy}");
            }

        }
    }
}
