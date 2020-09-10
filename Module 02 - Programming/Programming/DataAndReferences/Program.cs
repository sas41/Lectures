using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAndReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 10;
            int second = 5;

            Console.WriteLine($"{first} + {second} = {Add(first,second)}");

            AddToByData(first, second);
            Console.WriteLine($"First after AddToByData: {first}");

            AddToByReference(ref first, second);
            Console.WriteLine($"First after AddToByReference: {first}");

            Console.ReadLine();
        }

        // Standart Add Method
        static int Add(int a, int b)
        {
            return a + b;
        }

        // Trying to add B to A
        // by passing a variable.
        static void AddToByData(int a, int b)
        {
            a = a + b;
            Console.WriteLine($"A inside of AddToByData: {a}");
        }

        // Trying to add B to A
        // by passing the
        // REFERENCE to a variable
        static void AddToByReference(ref int a, int b)
        {
            a = a + b;
            Console.WriteLine($"A inside of AddToByReference: {a}");
        }
    }
}
