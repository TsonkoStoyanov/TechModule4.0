using System;
using System.Collections.Generic;
using System.Linq;

namespace P09_SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessonsSchedule = Console.ReadLine().Split(", ").ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "course start")
            {
                string[] inputArgs = input.Split(":").ToArray();

                string command = inputArgs[0];
                string lessonTitle = inputArgs[1];

                switch (command)
                {
                    case "Add":

                        if (!lessonsSchedule.Contains(lessonTitle))
                        {
                            lessonsSchedule.Add(lessonTitle);
                        }

                        break;

                    case "Insert":

                        int index = int.Parse(inputArgs[2]);

                        if (!lessonsSchedule.Contains(lessonTitle))
                        {
                            lessonsSchedule.Insert(index, lessonTitle);
                        }
                        break;

                    case "Remove":

                        if (lessonsSchedule.Contains(lessonTitle))
                        {
                            int nextLessonIndex = lessonsSchedule.IndexOf(lessonTitle) + 1;

                            lessonsSchedule.Remove(lessonTitle);


                            if (nextLessonIndex < lessonsSchedule.Count && lessonsSchedule[nextLessonIndex] == $"{lessonTitle}-Exercise")
                            {
                                lessonsSchedule.RemoveAt(nextLessonIndex);
                            }

                        }
                        break;

                    case "Swap":
                        string lessonTitle1 = inputArgs[1];
                        string lessonTitle2 = inputArgs[2];

                        int index1 = lessonsSchedule.IndexOf(lessonTitle1);
                        int index2 = lessonsSchedule.IndexOf(lessonTitle2);

                        if (index1 != -1 && index2 != -1)
                        {
                            lessonsSchedule[index1] = lessonTitle2;
                            lessonsSchedule[index2] = lessonTitle1;

                            if (index1 + 1 < lessonsSchedule.Count && lessonsSchedule[index1 + 1] == $"{lessonTitle1}-Exercise")
                            {
                                lessonsSchedule.RemoveAt(index1 + 1);
                                index1 = lessonsSchedule.IndexOf(lessonTitle1);
                                lessonsSchedule.Insert(index1 + 1, $"{lessonTitle1}-Exercise");
                            }

                            if (index2 + 1 < lessonsSchedule.Count && lessonsSchedule[index2 + 1] == $"{lessonTitle2}-Exercise")
                            {
                                lessonsSchedule.RemoveAt(index2 + 1);
                                index2 = lessonsSchedule.IndexOf(lessonTitle2);
                                lessonsSchedule.Insert(index2 + 1, $"{lessonTitle2}-Exercise");
                            }
                        }

                        break;

                    case "Exercise":

                        index = lessonsSchedule.IndexOf(inputArgs[1]);

                        if (lessonsSchedule.Contains(inputArgs[1]) && !lessonsSchedule.Contains($"{inputArgs[1]}-Exercise"))
                        {
                            lessonsSchedule.Insert(index + 1, $"{inputArgs[1]}-Exercise");
                        }
                        else if (!lessonsSchedule.Contains(inputArgs[1]))
                        {
                            lessonsSchedule.Add(inputArgs[1]);
                            lessonsSchedule.Add($"{inputArgs[1]}-Exercise");
                        }

                        break;
                }
            }

            int count = 1;

            foreach (var lesson in lessonsSchedule)
            {
                Console.WriteLine($"{count++}.{lesson}");
            }
        }


    }
}
