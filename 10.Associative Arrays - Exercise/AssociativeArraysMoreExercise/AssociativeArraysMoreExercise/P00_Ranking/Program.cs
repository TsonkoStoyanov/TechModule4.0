using System;
using System.Collections.Generic;
using System.Linq;

namespace P00_Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;

            var contests = new Dictionary<string, string>();

            var submissions = new SortedDictionary<string, Dictionary<string, int>>();

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] inputArgs = input.Split(":");

                string contest = inputArgs[0];
                string password = inputArgs[1];

                contests.Add(contest, password);
            }

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] inputArgs = input.Split("=>");

                string contest = inputArgs[0];
                string password = inputArgs[1];

                string user = inputArgs[2];
                int score = int.Parse(inputArgs[3]);

                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (!submissions.ContainsKey(user))
                    {
                        submissions.Add(user, new Dictionary<string, int>());
                    }

                    if (!submissions[user].ContainsKey(contest))
                    {
                        submissions[user].Add(contest, score);
                    }
                    else
                    {
                        if (submissions[user][contest] < score)
                        {
                            submissions[user][contest] = score;
                        }
                    }

                }

            }

            var bestCandidate = submissions
                    .OrderByDescending(x => x.Value.Values.Sum())
                    .ToDictionary(x => x.Key, x => x.Value.Values.Sum()).First();

            Console.WriteLine($"Best candidate is {bestCandidate.Key} with total {bestCandidate.Value} points.");
            Console.WriteLine("Ranking: ");

            foreach (var item in submissions)
            {
                Console.WriteLine($"{item.Key}");

                foreach (var submission in item.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {submission.Key} -> {submission.Value}");
                }
            }
        }
    }
}

