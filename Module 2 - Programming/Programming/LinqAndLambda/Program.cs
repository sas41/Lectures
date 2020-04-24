using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();

            Console.WriteLine($"Min: {numbers.Min()}");
            Console.WriteLine($"Max: {numbers.Max()}");
            Console.WriteLine($"Sum: {numbers.Sum()}");
            Console.WriteLine($"Average: {numbers.Average()}");

            Console.WriteLine("Regenerating...");
            Random rng = new Random();
            for (int i = 0; i < 20; i++)
            {
                numbers.Add(rng.Next(-20, 20));
            }

            Print(numbers);

            // Take
            List<int> firstFive = numbers.Take(5).ToList();
            Print(firstFive);
            
            // Skip
            List<int> lastFive = numbers.Skip(15).ToList();
            Print(lastFive);

            //Skip and Take
            List<int> middleTen = numbers.Skip(5).Take(10).ToList();
            Print(middleTen);

            // Select Query
            List<int> multiplied = numbers.Select(num => num * 2).ToList();
            Print(multiplied);

            // Where
            List<int> evens = numbers.Where(num => num % 2 == 0).ToList();
            Print(evens);

            // OrderBy / OrderByDescending
            List<int> ordered = numbers.OrderBy(num => num).ToList();
            Print(ordered);

            // Combining them
            List<int> combined = numbers.Select(num => num * 3)
                                        .Where(num => num % 2 != 0)
                                        .OrderByDescending(num => num)
                                        .ToList();
            Print(combined);

            Console.ReadLine();
        }

        static void Print(List<int> list)
        {
            Console.WriteLine(string.Join(",  ", list));
        }
    }
}
