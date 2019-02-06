using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfInput = int.Parse(Console.ReadLine());

            int maxSnowballSnow = 0;

            int maxSnowballTime = 0;

            int maxSnowballQuality = 0;

            BigInteger maxResult = 0;
            
            for (int i = 0; i < numbersOfInput; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                
                int snowballTime  = int.Parse(Console.ReadLine());
                
                int snowballQuality   = int.Parse(Console.ReadLine());

                BigInteger result = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);


                if (result > maxResult)
                {
                    maxResult = result;
                    maxSnowballSnow = snowballSnow;
                    maxSnowballTime = snowballTime;
                    maxSnowballQuality = snowballQuality;
                    
                }

            }

            Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {maxResult} ({maxSnowballQuality})");
        }
    }
}