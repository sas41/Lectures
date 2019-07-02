using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAndReserveTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Team ourTeam = new Team("The Rodeisland Raptors");

            for (int i = 0; i < count; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                string fName = input[0];
                string lName = input[1];
                int age = int.Parse(input[2]);
                double salary = double.Parse(input[3]);

                Person newPlayer = new Person(fName, lName, age, salary);

                ourTeam.AddPlayer(newPlayer);
            }

            Console.WriteLine($"The First team has {ourTeam.FirstTeam.Count} players.");
            Console.WriteLine($"The Reserve Team has {ourTeam.ReserveTeam.Count} players.");
        }
    }
}
