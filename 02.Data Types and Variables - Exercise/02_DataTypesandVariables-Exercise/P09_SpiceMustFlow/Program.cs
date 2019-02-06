using System;
using System.Xml.Schema;

namespace P09_SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            long source = long.Parse(Console.ReadLine());

            int day = 0;

            long totalSpice = 0;

            while (source >= 100)
            {
                totalSpice += source;
                day++;
                if (totalSpice < 26)
                {
                    totalSpice = 0;
                }
                else
                {
                    totalSpice -= 26;

                }
                source -= 10;
            }

            if (totalSpice < 26)
            {
                totalSpice = 0;
            }
            else
            {
                totalSpice -= 26;

            }

            Console.WriteLine(day);
            Console.WriteLine(totalSpice);
        }
    }
}
