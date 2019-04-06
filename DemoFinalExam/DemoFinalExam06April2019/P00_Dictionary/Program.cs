using System;
using System.Collections.Generic;
using System.Linq;

namespace P00_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dictionary = Console.ReadLine().Split(" | ");
            string[] words = Console.ReadLine().Split(" | ");

            List<string> list = new List<string>();
            
            Dictionary<string, List<string>> wordsWithDefinition = new Dictionary<string, List<string>>();

            foreach (var wordWithDefinition in dictionary)
            {
                string[] wordArgs = wordWithDefinition.Split(": ");

                string word = wordArgs[0];
                string definition = wordArgs[1];

                if (!wordsWithDefinition.ContainsKey(word))
                {
                    wordsWithDefinition.Add(word, new List<string>());
                    list.Add(word);
                }

                wordsWithDefinition[word].Add(definition);
            }


            foreach (var word in words)
            {
                if (wordsWithDefinition.ContainsKey(word))
                {
                    Console.WriteLine(word);

                    foreach (var def in wordsWithDefinition[word].OrderByDescending(x=>x.Length))
                    {
                        Console.WriteLine($"-{def}");
                    }
                }
            }


            string howToEnd = Console.ReadLine();

            if (howToEnd=="List")
            {
                var orderedList = list.OrderBy(x => x).ToList();

                Console.WriteLine(string.Join(" ", orderedList));

            }
            else
            {
                return;
            }

        }
    }
}
