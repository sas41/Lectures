using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFilledBox
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintBox(input);

            Console.ReadKey();
        }

        static void PrintBox(int size)
        {
            PrintTopBottom(size);

            for (int i = 0; i < size - 2; i++)
            {
                PrintBody(size);
            }

            PrintTopBottom(size);
        }

        static void PrintTopBottom(int size)
        {
            string output = new string('-', size * 2);
            Console.WriteLine(output);
        }

        static void PrintBody(int size)
        {
            string output = "";

            for (int i = 0; i < size-1; i++)
            {
                output = output + @"\/";
            }

            output = "-" + output + "-";
            Console.WriteLine(output);
        }
    }
}
