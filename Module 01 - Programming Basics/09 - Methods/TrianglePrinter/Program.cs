using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglePrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintTriangle(input);

            Console.ReadKey();
        }

        static void PrintTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                PrintTriangleRow(i);
            }

            for (int i = size - 1; i > 0; i--)
            {
                PrintTriangleRow(i);
            }
        }

        static void PrintTriangleRow(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
