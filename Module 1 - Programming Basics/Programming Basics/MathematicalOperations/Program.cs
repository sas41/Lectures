using System;

namespace MathematicalOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);

            input = Console.ReadLine();
            int otherNumber = int.Parse(input);

            int sum = number + otherNumber;

            Console.WriteLine(sum);
        }
    }
}
