using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                string[] commands = input.Split();

                if (commands[0] == "add")
                {
                    double first = double.Parse(commands[1]);
                    double second = double.Parse(commands[2]);
                    double result = Arithmetic.Add(first, second);
                    Console.WriteLine($"Result: {result}");
                }
                else if (commands[0] == "subtract")
                {
                    double first = double.Parse(commands[1]);
                    double second = double.Parse(commands[2]);
                    double result = Arithmetic.Subtract(first, second);
                    Console.WriteLine($"Result: {result}");
                }
                else if (commands[0] == "multiply")
                {
                    double first = double.Parse(commands[1]);
                    double second = double.Parse(commands[2]);
                    double result = Arithmetic.Multiply(first, second);
                    Console.WriteLine($"Result: {result}");
                }
                else if (commands[0] == "divide")
                {
                    double first = double.Parse(commands[1]);
                    double second = double.Parse(commands[2]);
                    double result = Arithmetic.Divide(first, second);
                    Console.WriteLine($"Result: {result}");
                }
                else if (commands[0] == "exit")
                {
                    break;
                }
            }
        }
    }
}
