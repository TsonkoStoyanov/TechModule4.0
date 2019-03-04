using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Santa_sList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kids = Console.ReadLine().Split("&").ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Finished!")
            {
                string[] inputArgs = input.Split();

                string command = inputArgs[0];
                string kidName = inputArgs[1];

                switch (command)
                {
                    case "Bad":
                        if (!IsKidExist(kids, kidName))
                        {
                            kids.Insert(0, kidName);
                        }
                        break;

                    case "Good":
                        if (IsKidExist(kids, kidName))
                        {
                            kids.Remove(kidName);
                        }
                        break;

                    case "Rename":
                        if (IsKidExist(kids, kidName))
                        {
                            string newKidName = inputArgs[2];

                            int index = kids.IndexOf(kidName);
                            kids[index] = newKidName;
                        }
                        break;
                    case "Rearrange":
                        if (IsKidExist(kids, kidName))
                        {
                            kids.Remove(kidName);
                            kids.Add(kidName);
                        }
                        break;
                }

            }
                Console.WriteLine(string.Join(", ", kids));
        }

        private static bool IsKidExist(List<string> kids, string kidName)
        {
            return kids.Any(x => x == kidName);
        }
    }
}
