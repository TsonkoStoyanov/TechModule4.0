using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, List<double>>();

            int numbersOfInput = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numbersOfInput; i++)
            {
                string student = Console.ReadLine();

                double grade = double.Parse(Console.ReadLine());
                
                if (!students.ContainsKey(student))
                {
                    students.Add(student, new List<double>());
                }

                students[student].Add(grade);

            }

            var result = students.Where(x => x.Value.Average() >= 4.50).OrderByDescending(x => x.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);


            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
            }
        }
    }
}
