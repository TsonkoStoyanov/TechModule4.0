﻿using System;
using System.Xml.XPath;

namespace P01_Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string result = string.Empty;

            if (age >= 66)
            {
                result = "elder";
            }
            else if (age >= 20 && age <= 65)
            {
                result = "adult";
            }
            else if (age >= 14 && age <= 19)
            {
                result = "teenager";
            }
            else if (age >= 3 && age <= 13)
            {
                result = "child";
            }
            else
            {
                result = "baby";
            }

            Console.WriteLine(result);
        }
    }
}
