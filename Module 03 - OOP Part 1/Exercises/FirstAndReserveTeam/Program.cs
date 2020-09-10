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
            Team myTeam = new Team("Team1");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string fname = input[0];
                string lname = input[1];
                int age = int.Parse(input[2]);

                Person person = new Person(fname, lname, age);
                myTeam.AddPlayer(person);
            }

            Console.WriteLine($"First Team: {myTeam.First.Count}");
            Console.WriteLine($"Reserve Team: {myTeam.Reserve.Count}");

            Console.ReadLine();
        }
    }
}
