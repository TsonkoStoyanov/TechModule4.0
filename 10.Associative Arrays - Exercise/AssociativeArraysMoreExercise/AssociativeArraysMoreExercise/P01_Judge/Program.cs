using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace P01_Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            var contests = new Dictionary<string, Dictionary<string, int>>();

            var individualScore = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] inputArgs = input.Split(" -> ");

                string userName = inputArgs[0];

                string contest = inputArgs[1];

                int score = int.Parse(inputArgs[2]);

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, new Dictionary<string, int>());
                }

                if (!contests[contest].ContainsKey(userName))
                {
                    contests[contest].Add(userName, score);

                    
                }
                else
                {
                    if (contests[contest][userName] < score)
                    {
                        contests[contest][userName] = score;
                    }
                }

            }

            
   
            foreach (var item in contests)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Values.Count} participants");

                int count = 1;

                foreach (var cont in item.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    if (!individualScore.ContainsKey(cont.Key))
                    {
                        individualScore.Add(cont.Key, 0);
                    }

                    individualScore[cont.Key] += cont.Value;

                    Console.WriteLine($"{count++}. {cont.Key} <::> {cont.Value}");
                }

            }

            Console.WriteLine($"Individual standings:");
            int countIndex = 1;
            foreach (var iKeyValuePair in individualScore.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{countIndex++}. {iKeyValuePair.Key} -> {iKeyValuePair.Value}");
            }
        }
    }
}
