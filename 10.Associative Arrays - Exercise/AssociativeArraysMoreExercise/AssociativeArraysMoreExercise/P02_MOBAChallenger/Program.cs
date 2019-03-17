using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();

            while ((input = Console.ReadLine()) != "Season end")
            {
                string firstPlayer = string.Empty;
                string secondPlayer = string.Empty;

                string position = string.Empty;
                int points = 0;

                string[] inputArgs = new string[3];

                if (input.Contains("->"))
                {
                    inputArgs = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    firstPlayer = inputArgs[0];
                    position = inputArgs[1];
                    points = int.Parse(inputArgs[2]);


                    if (!players.ContainsKey(firstPlayer))
                    {
                        players.Add(firstPlayer, new Dictionary<string, int>());
                    }

                    if (!players[firstPlayer].ContainsKey(position))
                    {
                        players[firstPlayer].Add(position, points);
                    }
                    else
                    {
                        if (players[firstPlayer][position] < points)
                        {
                            players[firstPlayer][position] = points;
                        }
                    }
                }
                else if (input.Contains("vs"))
                {
                    inputArgs = input.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);
                    firstPlayer = inputArgs[0];
                    secondPlayer = inputArgs[1];

                    if (!players.ContainsKey(firstPlayer) || !players.ContainsKey(secondPlayer))
                    {
                        continue;
                    }

                    foreach (var pos in players[firstPlayer])
                    {
                        string currentPosition = pos.Key;

                        if (players[secondPlayer].ContainsKey(currentPosition))
                        {
                            if (players[firstPlayer][currentPosition] > players[secondPlayer][currentPosition])
                            {
                                players.Remove(secondPlayer);
                                break;
                            }
                            else if (players[firstPlayer][currentPosition] < players[secondPlayer][currentPosition])
                            {
                                players.Remove(firstPlayer);
                                break;
                            }
                        }
                    }

                }

            }

            foreach (var player in players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                foreach (var position in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
