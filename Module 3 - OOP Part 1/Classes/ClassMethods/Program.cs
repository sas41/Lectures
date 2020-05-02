using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonV2 person1 = new PersonV2();
            person1.firstName = "Gosho";
            person1.lastName = "Petrov";
            person1.age = 26;
            person1.height = 178;
            person1.ssn = "9402158770";

            PersonV2 person2 = new PersonV2();
            person2.firstName = "Pesho";
            person2.lastName = "Georgiev";
            person2.age = 24;
            person2.height = 185;
            person2.ssn = "9611026550";

            person1.PrintInfo();
            Console.WriteLine();
            person2.PrintInfo();

            Console.ReadLine();
        }
    }
}
