using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Dictionary<string, HashSet<string>> dwarfs = new Dictionary<string, HashSet<string>>();

            Dictionary<string, int> dwarfswithPhysics = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] inputArgs = input.Split(" <:> ");
                string dwarfName = inputArgs[0];
                string dwarfHatColor = inputArgs[1];

                int dwarfPhysics = int.Parse(inputArgs[2]);


                if (!dwarfs.ContainsKey(dwarfHatColor))
                {
                    dwarfs.Add(dwarfHatColor, new HashSet<string>());

                    if (!dwarfswithPhysics.ContainsKey(dwarfName))
                    {
                        dwarfswithPhysics.Add(dwarfName, dwarfPhysics);
                    }
                    else
                    {
                        if (dwarfswithPhysics[dwarfName] < dwarfPhysics)
                        {
                            dwarfswithPhysics[dwarfName] = dwarfPhysics;
                        }
                    }
                }
                dwarfs[dwarfHatColor].Add(dwarfName);
            }


            ;

        }
    }
}
