using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercises
{
    class Program
    {
        int input;
        static void Main(string[] args)
        {
            //RecieptPrinter();
            //SignOfInteger();
            TrainglePrinter();

            Console.ReadLine();
        }

        static void RecieptPrinter()
        {
            RecieptTop();
            RecieptMiddle();
            RecieptBottom();
        }
        static void RecieptTop()
        {
            Console.WriteLine("CASH RECIEPT");
            Console.WriteLine("-------------------------");
        }
        static void RecieptMiddle()
        {
            Console.WriteLine("Charged to: _____________");
            Console.WriteLine("Received by: ____________");
        }
        static void RecieptBottom()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("© IT-Kariera");
        }

        static void SignOfInteger()
        {
            int input = int.Parse(Console.ReadLine());
            PrintSign(input);
        }

        static void PrintSign(int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative!");
            }
            else
            {
                Console.WriteLine($"The number {number} is positive!");
            }
        }

        static void TrainglePrinter()
        {
            int input = int.Parse(Console.ReadLine());
            GenerateTriangle(input);
        }

        static void GenerateTriangle(int size)
        {
            // From top to middle
            for (int i = 1; i <= size; i++)
            {
                // Print from 1 to i
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }

                Console.WriteLine();
            }

            // From middle to bottom
            for (int i = size - 1; i >= 1; i--)
            {
                // Print from 1 to i
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }

                Console.WriteLine();
            }
        }
    }
}
