using System;
using System.Collections.Generic;
using System.Linq;

namespace P08_PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0;

            while (pokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int element = 0;

                if (index < 0)
                {
                    element = pokemons[0];
                    pokemons[0] = pokemons[pokemons.Count - 1];
                }
                else if (index > pokemons.Count - 1)
                {
                    element = pokemons[pokemons.Count - 1];
                    pokemons[pokemons.Count - 1] = pokemons[0];
                }
                else
                {
                    element = pokemons[index];
                    pokemons.RemoveAt(index);
                }

                
                sum += element;

                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (pokemons[i] > element)
                    {
                        pokemons[i] -= element;
                    }
                    else if (pokemons[i] <= element)
                    {
                        pokemons[i] += element;
                    }

                }

            }

            Console.WriteLine(sum);
        }
    }
}
