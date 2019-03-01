using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_QuestsJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> quests = Console.ReadLine().Split(", ").ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Retire!")
            {
                string[] inputArgs = input.Split(" - ");
                string quest = inputArgs[1];

                string command = inputArgs[0];

                switch (command)
                {
                    case "Start":
                        if (!IsQuestExist(quests, quest))
                        {
                            quests.Add(quest);
                        }
                        break;

                    case "Complete":
                        if (IsQuestExist(quests, quest))
                        {
                            quests.Remove(quest);
                        }
                        break;

                    case "Side Quest":
                        string[] questWithSideQuest = quest.Split(":");

                        quest = questWithSideQuest[0];
                        string sideQuest = questWithSideQuest[1];

                        int index = quests.IndexOf(quest);
                        bool containsSideQuest = quests.Contains(sideQuest);

                        if (index != -1 && !containsSideQuest)
                        {
                            quests.Insert(index + 1, sideQuest);
                        }

                        break;

                    case "Renew":

                        if (IsQuestExist(quests, quest))
                        {
                            quests.Remove(quest);
                            quests.Add(quest);
                        }
                        break;
                }

            }
            Console.WriteLine(string.Join(", ", quests));
        }

        private static bool IsQuestExist(List<string> quests, string quest)
        {
            return quests.Any(x => x == quest);
        }
    }
}
