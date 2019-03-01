using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04_TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int countOfTeams = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] inputArgs = Console.ReadLine().Split("-");
                string userName = inputArgs[0];
                string teamName = inputArgs[1];

                User user = new User(userName);

                if (!IsExistTeam(teams, teamName))
                {

                    if (IsCreatorOfteam(teams, userName))
                    {
                        Console.WriteLine($"{userName} cannot create another team!");
                        continue;
                    }

                    Team team = new Team(teamName);
                    team.Creator = user;
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {userName}!");


                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] inputArgs = input.Split("->");

                string userName = inputArgs[0];
                string teamName = inputArgs[1];

                User user = new User(userName);

                if (!IsExistTeam(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;

                }

                if (IsMemberOfAnotherTeam(teams, userName))
                {
                    Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                    continue;

                }

                Team team = teams.FirstOrDefault(x => x.Name == teamName);

                team.AddUserToTeam(user);
            }

            List<string> teamToDisband = new List<string>();

            foreach (var team in teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name))
            {
                if (team.Members.Count > 0)
                {
                    Console.WriteLine(team.Name);

                    int count = 1;

                    Console.WriteLine($"{new string('-', count++)} {team.Creator.Name}");

                    foreach (var member in team.Members.OrderBy(x => x.Name))
                    {
                        Console.WriteLine($"{new string('-', count)} {member.Name}");
                    }
                }
                else
                {
                    teamToDisband.Add(team.Name);
                }
            }

            Console.WriteLine($"Teams to disband:");

            if (teamToDisband.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, teamToDisband));
            }

        }

        private static bool IsMemberOfAnotherTeam(List<Team> teams, string userName)
        {
            
            if (IsCreatorOfteam(teams, userName))
            {
                return true;
            }

            foreach (var team in teams)
            {
                return team.Members.Any(x => x.Name == userName);
            }

            return false;
        }

        private static bool IsCreatorOfteam(List<Team> teams, string userName)
        {
            foreach (var team in teams)
            {
                if (team.Creator.Name == userName)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsExistTeam(List<Team> teams, string teamName)
        {
            return teams.Any(t => t.Name == teamName);
        }
    }

    class User
    {
        public User(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }

    class Team
    {
        public Team(string name)
        {
            Name = name;
            Members = new List<User>();
        }

        public string Name { get; set; }
        public User Creator { get; set; }
        public List<User> Members { get; set; }

        public void AddUserToTeam(User user)
        {
            Members.Add(user);
        }


    }
}
