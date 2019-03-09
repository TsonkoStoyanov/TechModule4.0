using System;

namespace _01._Hogswatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int homesToVisit = int.Parse(Console.ReadLine());

            int initialPresents = int.Parse(Console.ReadLine());

            int presents = initialPresents;

            int timesGoingBack = 0;

            int additionalPresents = 0;

            int additionalPresentsTaken = 0;

            for (int i = 1; i <= homesToVisit; i++)
            {
                int presentNeedToLeft = int.Parse(Console.ReadLine());


                if (presents - presentNeedToLeft < 0)
                {
                    timesGoingBack++;
                    int remainingPresent = presentNeedToLeft - presents;

                    additionalPresents = (initialPresents / i) * (homesToVisit - i) + remainingPresent;
                    additionalPresentsTaken += additionalPresents;
                    presents = additionalPresents;
                    presents -= remainingPresent;

                }
                else
                {
                    presents -= presentNeedToLeft;
                }

            }

            if (timesGoingBack > 0)
            {
                Console.WriteLine(timesGoingBack);
                Console.WriteLine(additionalPresentsTaken);
            }
            else
            {
                Console.WriteLine(presents);
            }

        }
    }
}
