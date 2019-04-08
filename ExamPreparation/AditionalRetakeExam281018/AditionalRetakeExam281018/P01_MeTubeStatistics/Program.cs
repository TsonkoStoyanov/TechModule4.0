using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_MeTubeStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Dictionary<string, int> videosWithViews = new Dictionary<string, int>();
            Dictionary<string, int> videosWithRates = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "stats time")
            {
                string[] inputArgs = new string[2];
                string videoName = String.Empty;
                string rate = string.Empty;
                int views = 0;
                int likes = 0;

                if (input.Contains("-"))
                {
                    inputArgs = input.Split("-");
                    videoName = inputArgs[0];
                    views = int.Parse(inputArgs[1]);

                    if (!videosWithViews.ContainsKey(videoName))
                    {
                        videosWithViews.Add(videoName, 0);
                        videosWithRates.Add(videoName, 0);
                    }

                    videosWithViews[videoName] += views;
                }
                else if (input.Contains(":"))
                {
                    inputArgs = input.Split(":");
                    rate = inputArgs[0];
                    videoName = inputArgs[1];

                    if (rate == "like")
                    {
                        if (videosWithRates.ContainsKey(videoName))
                        {
                            videosWithRates[videoName]++;
                        }
                    }
                    else if (rate == "dislike")
                    {
                        if (videosWithRates.ContainsKey(videoName))
                        {
                            videosWithRates[videoName]--;
                        }
                    }
                }

            }

            input = Console.ReadLine();

            if (input == "by likes")
            {
                foreach (var video in videosWithRates.OrderByDescending(x=>x.Value))
                {
                    string videoName = video.Key;

                    Console.WriteLine($"{videoName} - {videosWithViews[videoName]} views - {video.Value} likes");
                }
            }
            else if (input == "by views")
            {
                foreach (var video in videosWithViews.OrderByDescending(x=>x.Value))
                {
                    string videoName = video.Key;

                    Console.WriteLine($"{videoName} - {video.Value} views - {videosWithRates[videoName]} likes");
                }
            }
        }
    }
}
