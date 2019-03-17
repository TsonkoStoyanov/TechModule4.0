using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArgs = input.Split(" : ");

                string course = inputArgs[0];

                string student = inputArgs[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                }

                courses[course].Add(student);
            }

            foreach (var item in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                foreach (var s in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {s}");
                }
            }
        }
    }
}
