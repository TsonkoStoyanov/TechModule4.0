using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace P10_ArrayManipulator
{
    class Program
    {


        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArgs = input.Split();

                string command = inputArgs[0];

                switch (command)
                {

                }

            }

        }
    }
}
