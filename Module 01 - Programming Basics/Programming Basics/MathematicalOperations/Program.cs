using System;

namespace MathematicalOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parsing text in to a number:
            // 
            // Конвертиране от текст в число:
            string input = Console.ReadLine();
            double number = double.Parse(input);

            // Using the result from one Method
            // as input for another method.
            //
            // Ползване на резултат от един метод
            // за вход на друг метод.
            double otherNumber = double.Parse(Console.ReadLine());

            double result = Math.Max(number, otherNumber) - Math.Min(number, otherNumber);
            //double result = Math.Abs(number - otherNumber);

            // Math.Ceiling(number): Rounds "number" up.
            //
            // Math.Ceiling(number): Закръгля "number" нагоре.
            Console.WriteLine(Math.Ceiling(result));

            Console.WriteLine(result);

            // Math.Floor(number): Rounds "number" down.
            //
            // Math.Floor(number): Закръгля "number" надолу.
            Console.WriteLine(Math.Floor(result));
        }
    }
}
