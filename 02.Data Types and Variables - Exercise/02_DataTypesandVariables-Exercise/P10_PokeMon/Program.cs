using System;
using System.Runtime.CompilerServices;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());

            int distance = int.Parse(Console.ReadLine());

            int exhaustionFactor = int.Parse(Console.ReadLine());

            int count = 0;

            int halfPokePower = pokePower / 2;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                count++;

                if (halfPokePower == pokePower)
                {
                    if (exhaustionFactor > 0 && exhaustionFactor <= pokePower)
                    {
                        pokePower /= exhaustionFactor;
                    }
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(count);
        }
    }
}