using System;
using System.Linq;
using System.Threading;

namespace P05_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            int count = 0;

            while (count < 4)
            {
                bool isEqual = true;

                string password = Console.ReadLine();

                if (username.Length != password.Length)
                {
                    isEqual = false;
                }

                for (int i = 0; i < username.Length; i++)
                {
                    if (username[i] != password[password.Length - 1 - i])
                    {
                        isEqual = false;
                        break;
                    }
                }

                count++;

                if (isEqual)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }

                if (count < 4)
                {
                    Console.WriteLine($"Incorrect password. Try again.");

                }
                else
                {
                    Console.WriteLine($"User {username} blocked!");

                }

            }


        }
    }
}

