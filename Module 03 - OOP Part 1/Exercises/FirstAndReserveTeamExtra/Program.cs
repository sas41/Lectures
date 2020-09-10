using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAndReserveTeamExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Team> teams = new Dictionary<string, Team>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] commands = input.Split(';');

                if (commands[0] == "Team")
                {
                    string teamName = commands[1];
                    Team currentTeam = new Team(teamName);
                    teams.Add(teamName, currentTeam);
                }
                else if (commands[0] == "Add")
                {
                    string teamName = commands[1];

                    if (teams.ContainsKey(teamName))
                    {

                        string playerName = commands[2];
                        int endurance = int.Parse(commands[3]);
                        int sprint = int.Parse(commands[4]);
                        int dribble = int.Parse(commands[5]);
                        int passing = int.Parse(commands[6]);
                        int shooting = int.Parse(commands[7]);

                        Player currentPlayer = new Player(playerName, endurance, sprint, dribble, passing, shooting);

                            teams[teamName].AddPlayer(currentPlayer);
                    }
                    else
                    {
                        Console.WriteLine($"Team {teamName}  does not exists.");
                    }
                }
                else if (commands[0] == "Remove")
                {

                    string teamName = commands[1];
                    string playerName = commands[2];

                    if (teams.ContainsKey(teamName))
                    {
                        teams[teamName].RemovePlayer(playerName);
                    }
                }
                else if (commands[0] == "Rating")
                {

                    string teamName = commands[1];

                    if (teams.ContainsKey(teamName))
                    {
                        Console.WriteLine($"{teamName} - {teams[teamName].Rating}");
                    }
                    else
                    {
                        Console.WriteLine($"Team {teamName}  does not exists.");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
