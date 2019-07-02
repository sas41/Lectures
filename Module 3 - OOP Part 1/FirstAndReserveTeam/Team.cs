using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAndReserveTeam
{
    class Team
    {
        public string Name { get; set; }
        public List<Person> FirstTeam { get; private set; }
        public List<Person> ReserveTeam { get; private set; }

        public Team(string name)
        {
            Name = name;
            FirstTeam = new List<Person>();
            ReserveTeam = new List<Person>();
        }

        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
            {
                FirstTeam.Add(player);
            }
            else
            {
                ReserveTeam.Add(player);
            }
        }


    }
}
