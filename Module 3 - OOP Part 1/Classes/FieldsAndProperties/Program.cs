using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsAndProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonV3 person1 = new PersonV3();
            person1.FirstName = "G-";
            person1.LastName = "Petrov";
            person1.Age = 26;
            person1.Height = 175;
            person1.SSN = "9402158770";

            PersonV3 person2 = new PersonV3();
            person2.FirstName = "Pesho";
            person2.LastName = "Georgiev";
            person2.Age = 24;
            person2.Height = 185;
            person2.SSN = "9611026550";

            person1.PrintInfo();
            Console.WriteLine();
            person2.PrintInfo();

            Console.ReadLine();
        }
    }
}
