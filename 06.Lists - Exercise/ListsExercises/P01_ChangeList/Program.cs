using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArgs = input.Split();
                int element = int.Parse(inputArgs[1]);

                if (inputArgs.Length > 2)
                {
                    int position = int.Parse(inputArgs[2]);
                    list.Insert(position, element);

                }
                else
                {
                    list.RemoveAll(x => x == element);
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
