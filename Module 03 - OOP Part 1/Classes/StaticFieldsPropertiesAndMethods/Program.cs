using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticFieldsPropertiesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(PersonV5.TotalCount);

            PersonV5 person1 = new PersonV5("Gosho", "Petrov", 26, 175, "9402158770");

            Console.WriteLine(PersonV5.TotalCount);

            PersonV5 person2 = new PersonV5("Pesho", "Georgiev", 24, 185, "9611026550");

            Console.WriteLine(PersonV5.TotalCount);

            foreach (var person in PersonV5.People)
            {
                person.PrintInfo();
                Console.WriteLine();
            }

            Console.WriteLine("Changing Heigts...");
            PersonV5.ChangeAllHeights(200);
            Console.WriteLine();

            foreach (var person in PersonV5.People)
            {
                person.PrintInfo();
                Console.WriteLine();
            }

            string text = PersonV5.GetInfo(person1);
            Console.WriteLine(text);

            int number = int.Parse("100");

            Console.ReadLine();
        }
    }
}
