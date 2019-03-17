using System;
using System.Collections.Generic;

namespace P07_CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            var companies = new SortedDictionary<string, HashSet<string>>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArgs = input.Split(" -> ");

                string company = inputArgs[0];
                string employeeId = inputArgs[1];

                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new HashSet<string>());
                }

                companies[company].Add(employeeId);
            }

            foreach (var company in companies)
            {
                Console.WriteLine(company.Key);

                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
