using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_LastStop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> paintingNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] inputArgs = input.Split();

                string command = inputArgs[0];

                int paintingNumber = 0;


                switch (command)
                {
                    case "Change":
                        paintingNumber = int.Parse(inputArgs[1]);
                        int changedNumber = int.Parse(inputArgs[2]);

                        int index = paintingNumbers.IndexOf(paintingNumber);

                        if (index != -1)
                        {
                            paintingNumbers[index] = changedNumber;
                        }

                        break;

                    case "Hide":
                        paintingNumber = int.Parse(inputArgs[1]);
                        paintingNumbers.Remove(paintingNumber);
                        break;

                    case "Switch":
                        paintingNumber = int.Parse(inputArgs[1]);
                        int paintingNumber2 = int.Parse(inputArgs[2]);

                        int index1 = paintingNumbers.IndexOf(paintingNumber);
                        int index2 = paintingNumbers.IndexOf(paintingNumber2);

                        if (index1 != -1 && index2 != -1)
                        {
                            int temp = paintingNumbers[index1];
                            paintingNumbers[index1] = paintingNumbers[index2];
                            paintingNumbers[index2] = temp;
                        }


                        break;

                    case "Insert":
                        int place = int.Parse(inputArgs[1]);
                        paintingNumber = int.Parse(inputArgs[2]);

                        if (place + 1 < paintingNumbers.Count - 1 && place + 1 >= 0)
                        {
                            paintingNumbers.Insert(place + 1, paintingNumber);
                        }
                        break;

                    case "Reverse":
                        paintingNumbers.Reverse();
                        break;
                }

            }

            Console.WriteLine(String.Join(" ", paintingNumbers));
        }


    }
}
