using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    class Team
    {
        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Members = new List<string>();                                                // Винаги да си добавям ЛИСТА, ако имам 
        }

        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public string ConvertToString()                                                 // Метод който се намира в класа и принти OUTPUT-A
        {
            Members.Sort();                                                             // Сортирам ИМЕНАТА НА УЧАСТНИЦИТЕ в отборите по азбучен ред                                                    

            string result = "";

            result += Name + "\n";                                                      // "\n" пренася резултата на нов ред
            result += $"- {Creator}\n";
            foreach (string member in Members)
            {
                result += $"-- {member}\n";
            }

            return result.Trim();                                                       // Маха празните редове в OUTPUT-A
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int teamsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < teamsCount; i++)
            {
                string creatorTeamString = Console.ReadLine();
                string[] arguments = creatorTeamString.Split('-');
                string creatorName = arguments[0];
                string teamName = arguments[1];


                // Проверявам дали един Създател се опитва да създаде друг отбор
                Team team = new Team(teamName, creatorName);
                Team sameTeamFound = teams.Find(team => team.Name == teamName);
                Team sameCreatorFound = teams.Find(team => team.Creator == creatorName);

                if (sameTeamFound != null)
                {
                    Console.WriteLine($"Team {team.Name} was already created!");
                    continue;
                }

                if (sameCreatorFound != null)
                {
                    Console.WriteLine($"{team.Creator} cannot create another team!");
                    continue;
                }

                teams.Add(team);
                Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
            }

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] arguments = command.Split("->");
                string memberName = arguments[0];
                string teamName = arguments[1];

                //Team existTeamWithSameMember = teams.Find(team => team.Members.Contains(memberName));   // Търся участник в повече от един обор
                // Това горе е по-краткия вариянт, който вече ще е добре да ползвам
                Team existTeamWithSameMember = null;
                foreach (Team team in teams)
                {
                    if (team.Members.Contains(memberName))
                    {
                        existTeamWithSameMember = team;
                        break;
                    }
                }

                if (existTeamWithSameMember != null)
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;
                }

                Team foundTeam = teams.Find(team => team.Name == teamName);         // Преглеждам всички отбори и ще ми даде индекса, който съвпада с подаденото ми име на отбор
                if (foundTeam != null)
                {
                    if (foundTeam.Creator == memberName)                                 // Проверявам дали създателя на отбора иска да стане член на собстения си отбор
                    {
                        Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    }
                    else
                    {
                        foundTeam.Members.Add(memberName);                               // Добавям името на участника на отбора в отбора
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
            }

            // Принтиране
            List<Team> validTeams = teams.FindAll(team => team.Members.Count > 0);       // Търся отборите, в които ИМА участници освен създателя
            List<Team> disbandTeams = teams.FindAll(team => team.Members.Count == 0);    // Търся отборите, в които НЯМА участници освен създателя


            validTeams = validTeams
                .OrderByDescending(team => team.Members.Count)                           // Сортирам ИМЕНАТА НА УЧАСТНИЦИТЕ в отборите по азбучен ред (отзад-напред)
                .ThenBy(team => team.Name)                                               // Сортирам по ИМЕТО на отбора по азбучен ред
                .ToList();

            disbandTeams = disbandTeams
                .OrderBy(team => team.Name)
                .ToList();

            // Отборите с участници са валидни
            foreach (Team team in validTeams)
            {
                Console.WriteLine(team.ConvertToString());
            }

            // Отборите без участници са невалидни и се изписват след -> "Teams to disband:"
            Console.WriteLine($"Teams to disband:");
            foreach (Team team in disbandTeams)
            {
                Console.WriteLine(team.Name);
            }
        }
    }
}
