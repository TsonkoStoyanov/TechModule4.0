using System;
using System.Collections.Generic;
using System.Linq;

namespace P09_SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Dictionary<string, int> examsScore = new Dictionary<string, int>();

            Dictionary<string, int> countOfSubmissions = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] inputArgs = input.Split("-");

                string userName = inputArgs[0];

                string technology = inputArgs[1];

                int score = 0;

                if (technology == "banned")
                {
                    if (examsScore.ContainsKey(userName))
                    {
                        examsScore.Remove(userName);
                    }

                    continue;
                }

                if (inputArgs.Length > 2)
                {
                    score = int.Parse(inputArgs[2]);
                }


                if (!examsScore.ContainsKey(userName))
                {
                    examsScore.Add(userName, score);
                }
                else
                {
                    if (examsScore[userName] < score)
                    {
                        examsScore[userName] = score;
                    }
                }

                if (!countOfSubmissions.ContainsKey(technology))
                {
                    countOfSubmissions.Add(technology, 0);
                }

                countOfSubmissions[technology]++;
            }


            Console.WriteLine($"Results:");

            foreach (var item in examsScore.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            Console.WriteLine($"Submissions:");

            foreach (var item in countOfSubmissions.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
