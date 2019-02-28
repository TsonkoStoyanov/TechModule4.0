using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P07_AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] inputArgs = input.Split(" ");

                string command = inputArgs[0];

                if (command == "merge")
                {
                    int start = int.Parse(inputArgs[1]);
                    int end = int.Parse(inputArgs[2]);

                    if (start > list.Count - 1)
                    {
                        continue;
                    }
                    int startIndex = Math.Max(0, start);
                    int endIndex = Math.Min(list.Count - 1, end);

                    list = Merge(list, startIndex, endIndex);

                }
                else if (command == "divide")
                {
                    int index = int.Parse(inputArgs[1]);
                    int partitions = int.Parse(inputArgs[2]);

                    list = Divide(list, index, partitions);
                }

            }

            Console.WriteLine(string.Join(" ", list));
        }

        private static List<string> Divide(List<string> list, int index, int partitions)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < index; i++)
            {
                result.Add(list[i]);
            }

            string current = list[index];

            if (current.Length % partitions == 0)
            {
                int startIndex = 0;

                int piece = current.Length / partitions;

                while (partitions > 0)
                {
                    string part = current.Substring(startIndex, piece);
                    result.Add(part);
                    startIndex += piece;
                    partitions--;
                }
            }
            else
            {
                int startIndex = 0;

                int piece = current.Length / partitions;

                while (partitions > 1)
                {
                    string part = current.Substring(startIndex, piece);
                    result.Add(part);
                    startIndex += piece;
                    partitions--;
                }

                string lastPart = current.Substring(startIndex, current.Length - startIndex);

                result.Add(lastPart);
            }

            for (int i = index + 1; i < list.Count; i++)
            {
                result.Add(list[i]);
            }

            return result;
        }

        private static List<string> Merge(List<string> list, int startIndex, int endIndex)
        {
            List<string> result = new List<string>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < startIndex; i++)
            {
                result.Add(list[i]);
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                string current = list[i];
                sb.Append(current);
            }
            result.Add(sb.ToString().TrimEnd());

            for (int i = endIndex + 1; i < list.Count; i++)
            {
                result.Add(list[i]);
            }

            return result;


        }
    }
}
