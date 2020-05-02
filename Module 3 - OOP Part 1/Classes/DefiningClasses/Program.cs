using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> myList = new List<int>();

            PersonV1 person1 = new PersonV1();
            person1.firstName = "Gosho";
            person1.lastName = "Petrov";
            person1.age = 26;
            person1.height = 178;
            person1.ssn = "9402158770";

            PersonV1 person2 = new PersonV1();
            person2.firstName = "Pesho";
            person2.lastName = "Georgiev";
            person2.age = 24;
            person2.height = 185;
            person2.ssn = "9611026550";

            PrintInfo(person1);
            Console.WriteLine();
            PrintInfo(person2);

            Console.ReadLine();
        }

        static void PrintInfo(PersonV1 toPrint)
        {
            Console.WriteLine($"Hello, my name is {toPrint.firstName} {toPrint.lastName}");
            Console.WriteLine($"I am {toPrint.height}cm tall and I am {toPrint.age} years old.");
            Console.WriteLine($"My SSN is {toPrint.ssn}");
        }
    }
}
