using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int totalTickets = 0;
        int kidTickets = 0;
        int standartTickets = 0;
        int studentTickets = 0;

        while (input != "Finish")
        {
            int currentTickets = 0;
            int numberOfTickets = int.Parse(Console.ReadLine());


            for (int i = 0; i < numberOfTickets; i++)
            {

                string typeOfTicket = Console.ReadLine();

                if (typeOfTicket == "standard")
                {
                    standartTickets++;
                    currentTickets++;
                }
                else if (typeOfTicket == "student")
                {
                    studentTickets++;
                    currentTickets++;
                }
                else if (typeOfTicket == "kid")
                {
                    kidTickets++;
                    currentTickets++;
                }
                else if (typeOfTicket == "End")
                {
                    break;
                }
            }

            totalTickets += currentTickets;
            double fill = (currentTickets / (double) numberOfTickets) * 100;
            Console.WriteLine($"{input}-{fill:f2}% full.");

            input = Console.ReadLine();
        }

        Console.WriteLine($"Total tickets: {totalTickets}");
        Console.WriteLine($"{(studentTickets/(double)totalTickets)*100:f2}% student tickets.");
        Console.WriteLine($"{(standartTickets/(double)totalTickets)*100:f2}% standard tickets.");
        Console.WriteLine($"{(kidTickets/(double)totalTickets)*100:f2}% kids tickets.");

    }
}

