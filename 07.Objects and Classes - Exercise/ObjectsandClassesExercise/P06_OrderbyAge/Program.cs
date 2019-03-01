using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_OrderbyAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<Person> people = new List<Person>();

            while ((input= Console.ReadLine())!="End")
            {
                string[] inputArgs = input.Split();

                string name = inputArgs[0];

                string id = inputArgs[1];

                int age = int.Parse(inputArgs[2]);


                Person person = new Person(name, id, age);
                people.Add(person);
            }

            Console.WriteLine(string.Join(Environment.NewLine, people.OrderBy(x=>x.Age)));
        }
    }

    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
}
