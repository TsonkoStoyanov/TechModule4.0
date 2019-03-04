using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] snowmen = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isLast = false;

            while (snowmen.Length > 1)
            {
                for (int i = 0; i < snowmen.Length; i++)
                {
                    if (snowmen[i] == -1)
                    {
                        continue;
                    }

                    if (snowmen.Count(x => x >= 0) == 1)
                    {
                        break;
                    }

                    int target = snowmen[i];

                    if (target > snowmen.Length - 1)
                    {
                        target = target % snowmen.Length;
                    }

                    if (i == target)
                    {
                        Console.WriteLine($"{i} performed harakiri");
                        snowmen[i] = -1;
                        continue;
                    }

                    int dif = Math.Abs(i - target);

                    if (dif % 2 == 0)
                    {
                        Console.WriteLine($"{i} x {target} -> {i} wins");
                        snowmen[target] = -1;

                    }
                    else if (dif % 2 != 0)
                    {
                        Console.WriteLine($"{i} x {target} -> {target} wins");
                        snowmen[i] = -1;

                    }
                }

                
                int[] result = Array.FindAll(snowmen, x => x >= 0).ToArray();
                snowmen = result;
            }
        }
    }
}
