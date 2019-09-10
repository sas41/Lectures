using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationDemonstration
{
    class Program
    {
        static void NamePrinter()
        {
            try
            {
                string name = Console.ReadLine();

                Person testPerson = new Person();
                testPerson.Name = name;

                Console.WriteLine($"The person's name is: {testPerson.Name}");
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine("Caught inside Method!");
                NamePrinter();
                //throw argEx;
            }
        }

        static void Main(string[] args)
        {
            NamePrinter();

            List<string> text = new List<string>();
            

            Console.ReadKey();
        }
    }
}
