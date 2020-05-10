using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAndReserveTeamExtra
{
    class Team
    {
        public string TeamName { get; set; }
        public int Rating
        {
            get
            {
                return Convert.ToInt32(Math.Round(Players.Select(player => player.Average).Average()));
            }
        }

        public List<Player> Players { get; set; }

        public Team(string name)
        {
            TeamName = name;
            Players = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            //foreach (var player in Players)
            //{
            //    if (player.Name == playerName)
            //    {
            //        Players.Remove(player);
            //        return;
            //    }
            //}

            Player found = Players.Where(player => player.Name == playerName).FirstOrDefault();
            if (found != default)
            {
                Players.Remove(found);
                return;
            }

            Console.WriteLine($"Player {playerName} is not in {TeamName} team.");
        }
    }
}
