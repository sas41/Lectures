using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonV4 person1 = new PersonV4("Gosho", "Petrov", 26, 175, "9402158770");

            List<PersonV4> test = new List<PersonV4>() { person1 };

            PersonV4 person2 = new PersonV4("Pesho", "Georgiev", 24, 185, "9611026550", test.ToList());

            //person2.Friends.Add(person1);

            Console.WriteLine(person2.Friends.Count);




            //person1.PrintInfo();
            Console.WriteLine();
            //person2.PrintInfo();

            Console.ReadLine();
        }
    }
}
