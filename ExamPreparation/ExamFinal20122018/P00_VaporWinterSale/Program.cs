using System;
using System.Collections.Generic;
using System.Linq;

namespace P00_VaporWinterSale
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] games = Console.ReadLine().Split(", ");

            Dictionary<string, double> gamesWithDlc = new Dictionary<string, double>();

            Dictionary<string, double> gamesWithoutDlc = new Dictionary<string, double>();

            foreach (var gameWithPriceOrDLC in games)
            {

                string[] gameArgs = gameWithPriceOrDLC.Split("-");
                string game = string.Empty;
                if (gameArgs.Length == 2)
                {
                    game = gameArgs[0];

                    double price = double.Parse(gameArgs[1]);

                    if (!gamesWithoutDlc.ContainsKey(game))
                    {
                        gamesWithoutDlc.Add(game, price);
                    }
                }
                else
                {
                    gameArgs = gameWithPriceOrDLC.Split(":");
                    game = gameArgs[0];
                    string dlc = gameArgs[1];

                    if (gamesWithoutDlc.ContainsKey(game))
                    {
                        double temp = gamesWithoutDlc[game] * 1.2;
                        gamesWithoutDlc.Remove(game);
                        gamesWithDlc.Add($"{game} - {dlc}", temp);
                    }

                }

            }


            foreach (var game in gamesWithDlc.OrderBy(x => x.Value))
            {
                Console.WriteLine($"{game.Key} - {game.Value * 0.5:f2}");
            }
            foreach (var game in gamesWithoutDlc.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{game.Key} - {game.Value * 0.8:f2}");
            }
        }
    }
}
