using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_ChatLogger
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> chatLogger = new List<string>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArgs = input.Split();

                string command = inputArgs[0];

                switch (command)
                {
                    case "Chat":

                        string message = inputArgs[1];
                        chatLogger.Add(message);
                        break;

                    case "Delete":
                        message = inputArgs[1];
                        chatLogger.Remove(message);
                        break;

                    case "Edit":
                        string messageToEdit = inputArgs[1];
                        string editedMessage = inputArgs[2];

                        int index = chatLogger.IndexOf(messageToEdit);

                        //todo if exist
                        chatLogger[index] = editedMessage;

                        break;


                    case "Pin":
                        message = inputArgs[1];
                        index = chatLogger.IndexOf(message);

                        chatLogger.RemoveAt(index);
                        chatLogger.Add(message);
                        break;

                    case "Spam":
                        string[] messages = inputArgs.Skip(1).ToArray();

                        chatLogger.AddRange(messages);
                        break;


                }
            }

            foreach (var message in chatLogger)
            {
                Console.WriteLine(message);
            }

        }
    }
}
