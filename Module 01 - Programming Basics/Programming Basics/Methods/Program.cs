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
            CommandCycle();

            Console.ReadLine();
        }

        static void CommandCycle()
        {
            string command = Console.ReadLine();

            if (command == "pow")
            {
                Power();
            }
            else if (command == "fib")
            {
                Console.Write("Fibonacci Iteration Count: ");
                int iterationCount = int.Parse(Console.ReadLine());
                Fibonacci(iterationCount);
            }
            else if (command == "mul")
            {
                Console.Write("Enter a Number to Multiply by 2: ");
                int number = int.Parse(Console.ReadLine());
                int number2 = Multiply(number);
                Console.WriteLine("New Number: " + number2);
            }
            else if (command == "rec")
            {
                Console.Write("Enter a number to sum: ");
                int number = int.Parse(Console.ReadLine());
                int result = RecursiveAdd(number);
                Console.WriteLine(result);
            }
        }

        static void Power()
        {
            int num = 2;
            for (int i = 1; i <= 10; i++)
            {
                int current = 2;
                for (int j = 0; j < i; j++)
                {
                    current = current * num;
                }
                Console.Write(current + ", ");
            }
            Console.WriteLine();
        }

        static void Fibonacci(int iterations)
        {
            int fibA = 1;
            int fibB = 1;
            Console.Write("1, 1, ");

            for (int i = 0; i < iterations; i++)
            {
                int next = fibA + fibB;
                Console.Write(next + ", ");

                fibA = fibB;
                fibB = next;
            }

            Console.WriteLine();
        }

        static int Multiply(int number)
        {
            int newNumber = number * 2;
            return newNumber;
        }

        static int RecursiveAdd(int start)
        {
            if (start == 0)
            {
                return start;
            }
            return start + RecursiveAdd(start - 2);
        }
    }
}
