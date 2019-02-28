using System;
using System.Collections.Generic;
using System.Linq;

namespace P13_MixedupLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> remainingElements = new List<int>();

            if (list1.Count > list2.Count)
            {
                remainingElements = list1.TakeLast(2).ToList();

                foreach (var remainingElement in remainingElements)
                {
                    list1.Remove(remainingElement);
                }
            }
            else
            {
                remainingElements = list2.Take(2).ToList();

                foreach (var remainingElement in remainingElements)
                {
                    list2.Remove(remainingElement);
                }
            }

            int min = remainingElements.Min();
            int max = remainingElements.Max();

            List<int> result = new List<int>();

            for (int i = 0; i < list1.Count; i++)
            {
                result.Add(list1[i]);
                result.Add(list2[list2.Count - 1 - i]);
            }


            result = result.Where(x => x > min && x < max).OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
