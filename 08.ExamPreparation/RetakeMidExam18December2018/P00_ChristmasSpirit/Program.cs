using System;

namespace P00_ChristmasSpirit
{
    class Program
    {
        static void Main(string[] args)
        {
            int ornamentSet = 2;
            int treeSkirt = 5;
            int treeGarlands = 3;
            int treeLights = 15;

            int cristmasSpirit = 0;

            long cost = 0;

            int quiantity = int.Parse(Console.ReadLine());

            int days = int.Parse(Console.ReadLine());

            for (int currentDay = 1; currentDay <= days; currentDay++)
            {
                if (currentDay % 11 == 0)
                {
                    quiantity += 2;
                }

                if (currentDay % 2 == 0)
                {
                    cost += (quiantity * ornamentSet);
                    cristmasSpirit += 5;
                }

                if (currentDay % 3 == 0)
                {
                    cost += (quiantity * treeSkirt) + (treeGarlands * quiantity);
                    cristmasSpirit += 13;
                }

                if (currentDay % 5 == 0)
                {
                    cost += (quiantity * treeLights);
                    cristmasSpirit += 17;
                }

                if (currentDay % 10 == 0)
                {
                    cristmasSpirit -= 20;
                    cost += treeSkirt + treeGarlands + treeLights;
                }


                if (currentDay % 15 == 0)
                {
                    cristmasSpirit += 30;
                }
                
            }

            if (days % 10 == 0)
            {
                cristmasSpirit -= 30;
            }

            Console.WriteLine($"Total cost: {cost}");
            Console.WriteLine($"Total spirit: {cristmasSpirit}");
        }
    }
}
