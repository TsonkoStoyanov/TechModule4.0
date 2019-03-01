using System;

namespace P01_DungeonestDark
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealt = 100;
            int currentHealt = initialHealt;

            bool isAlive = true;

            int coins = 0;

            string[] rooms = Console.ReadLine().Split("|");

            int count = 1;




            for (int i = 0; i < rooms.Length; i++)
            {
                string[] inputArgs = rooms[i].Split();

                string itemOrMonster = inputArgs[0];

                if (itemOrMonster == "potion")
                {
                    int healthPoints = int.Parse(inputArgs[1]);
                    int actualPoints = 0;

                    if (healthPoints + currentHealt >= initialHealt)
                    {
                        actualPoints = initialHealt - currentHealt;

                        currentHealt = initialHealt;
                    }
                    else if (healthPoints + currentHealt < initialHealt)
                    {
                        currentHealt += healthPoints;
                        actualPoints = healthPoints;
                    }


                    Console.WriteLine($"You healed for {actualPoints} hp.");
                    Console.WriteLine($"Current health: {currentHealt} hp.");

                }
                else if (itemOrMonster == "chest")
                {
                    int coinsToAdd = int.Parse(inputArgs[1]);
                    coins += coinsToAdd;
                    Console.WriteLine($"You found {coinsToAdd} coins.");

                }
                else
                {
                    int damage = int.Parse(inputArgs[1]);

                    currentHealt -= damage;

                    if (currentHealt <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {itemOrMonster}.");
                        isAlive = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {itemOrMonster}.");
                    }
                }

                count++;
            }

            if (isAlive)
            {
                Console.WriteLine($"You\'ve made it!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Health: {currentHealt}");
            }
            else
            {
                Console.WriteLine($"Best room: {count}");
            }
        }
    }
}
