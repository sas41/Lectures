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
        public List<Person> First { get; set; }
        public List<Person> Reserve { get; set; }

        public Team(string name)
        {
            Name = name;

            First = new List<Person>();
            Reserve = new List<Person>();
        }

        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
            {
                First.Add(player);
            }
            else
            {
                Reserve.Add(player);
            }
        }
    }
}
