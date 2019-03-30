using System;
using System.Collections.Generic;
using System.Linq;

namespace P00_Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Dictionary<string, List<string>> bandsWithMembers = new Dictionary<string, List<string>>();
            Dictionary<string, long> bandsWithTime = new Dictionary<string, long>();

            while ((input = Console.ReadLine()) != "start of concert")
            {
                string[] inputArgs = input.Split("; ");

                string command = inputArgs[0];
                string band = inputArgs[1];

                if (command == "Add")
                {

                    if (!bandsWithMembers.ContainsKey(band))
                    {
                        bandsWithMembers.Add(band, new List<string>());
                        bandsWithTime.Add(band, 0);
                    }

                    if (inputArgs.Length > 2)
                    {
                        string[] members = inputArgs[2].Split(", ");

                        foreach (var member in members)
                        {
                            
                            if (!bandsWithMembers[band].Contains(member))
                            {
                                bandsWithMembers[band].Add(member);
                            }

                        }
                    }
                }
                else if (command == "Play")
                {
                    int time = int.Parse(inputArgs[2]);

                    if (!bandsWithMembers.ContainsKey(band))
                    {
                        bandsWithMembers.Add(band, new List<string>());
                        bandsWithTime.Add(band, 0);
                    }
                    
                    bandsWithTime[band] += time;
                }


            }

            string bandName = Console.ReadLine();
            
            var totalTime = bandsWithTime.Sum(x => x.Value);

            Console.WriteLine($"Total time: {totalTime}");

            foreach (var band in bandsWithTime.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }


            foreach (var band in bandsWithMembers.Where(x=>x.Key == bandName))
            {
                Console.WriteLine($"{band.Key}");
                foreach (var member in band.Value)
                {
                    Console.WriteLine($"=> {member}");                    
                }
            }
          
        }
    }
}
