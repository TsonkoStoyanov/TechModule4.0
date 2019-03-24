using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace P03_Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Dictionary<string, Dictionary<string, int>> dwarfs = new Dictionary<string, Dictionary<string, int>>();

            Dictionary<string, int> dwarfswithPhysics = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] inputArgs = input.Split(" <:> ");
                string dwarfName = inputArgs[0];
                string dwarfHatColor = inputArgs[1];

                int dwarfPhysics = int.Parse(inputArgs[2]);


                if (!dwarfs.ContainsKey(dwarfHatColor))
                {
                    dwarfs.Add(dwarfHatColor, new Dictionary<string, int>());
                }

                if (!dwarfs[dwarfHatColor].ContainsKey(dwarfName))
                {
                    dwarfs[dwarfHatColor].Add(dwarfName, dwarfPhysics);
                    dwarfswithPhysics.Add(dwarfName, dwarfPhysics);
                }
                else
                {
                    if (dwarfs[dwarfHatColor][dwarfName] < dwarfPhysics)
                    {
                        dwarfs[dwarfHatColor][dwarfName] = dwarfPhysics;
                        dwarfswithPhysics[dwarfName] = dwarfPhysics;
                    }
                }

            }

            foreach (var dwarf in dwarfswithPhysics.OrderByDescending(x=>x.Value))
            {
                string currentDwarfName = dwarf.Key;

                foreach (var item in dwarfs.OrderByDescending(x=>x.Value.Count))
                {
                    ;
                    Console.WriteLine($"({dwarfs[currentDwarfName]}) {currentDwarfName} <-> {dwarfs[currentDwarfName][currentDwarfName]}");
                }
            }


        }
    }
}
