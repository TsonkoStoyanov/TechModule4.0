using System;
using System.Collections.Generic;

namespace P02_HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommand = int.Parse(Console.ReadLine());

            List<string> people = new List<string>();

            for (int i = 0; i < numberOfCommand; i++)
            {
                string[] input = Console.ReadLine().Split();

                string person = input[0];

                if (input.Length > 3)
                {
                    if (!people.Contains(person))
                    {
                        Console.WriteLine($"{person} is not in the list!");
                    }
                    else
                    {
                        people.Remove(person);
                    }

                }
                else
                {
                    if (people.Contains(person))
                    {
                        Console.WriteLine($"{person} is already in the list!");
                    }
                    else
                    {
                        people.Add(person);
                    }
                }
            }

            foreach (var person in people)
            {
                Console.WriteLine(person);                
            }
        }
    }
}
