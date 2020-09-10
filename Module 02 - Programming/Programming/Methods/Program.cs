using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMessage();

            Console.WriteLine("--------------------");
            string input = Console.ReadLine();

            PrintMessage(input);

            Console.ReadLine();
        }

        static void PrintMessage()
        {
            Console.WriteLine("Welcome to this program!");
            Console.WriteLine("Today is a lovely day!");
            Console.WriteLine("Please write some stuff!");
        }

        static void PrintMessage(string name)
        {
            Console.WriteLine("Hello " + name + "!");
            Console.WriteLine("Welcome to this program!");
            Console.WriteLine("Today is a lovely day!");
            Console.WriteLine("Please write some stuff!");
        }

    }
}
