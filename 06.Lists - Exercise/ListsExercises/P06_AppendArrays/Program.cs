using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P06_AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine().Split(new char[] { '|'}, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<int> result = new List<int>();

            for (int i = arrays.Count - 1; i >= 0; i--)
            {
                List<int> numbers = arrays[i].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToList();

                foreach (var number in numbers)
                {
                    result.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
