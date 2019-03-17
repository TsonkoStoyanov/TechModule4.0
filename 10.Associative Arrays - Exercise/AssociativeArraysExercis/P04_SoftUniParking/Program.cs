using System;
using System.Collections.Generic;

namespace P04_SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parking = new Dictionary<string, string>();

            int numbersOfinput = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numbersOfinput; i++)
            {
                string[] input = Console.ReadLine().Split();

                string command = input[0];
                string username = input[1];
                

                if (command == "register")
                {
                    string licensePlateNumber = input[2];
                    if (!parking.ContainsKey(username))
                    {
                        parking.Add(username, licensePlateNumber);

                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parking[username]}");
                    }
                }
                else if (command == "unregister")
                {
                    if (!parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        parking.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var item in parking)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
