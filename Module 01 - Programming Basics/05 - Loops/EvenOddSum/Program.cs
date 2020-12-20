using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int evens = 0, odds = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    evens += int.Parse(Console.ReadLine());
                }
                else
                {
                    odds += int.Parse(Console.ReadLine());
                }
            }

            if (evens == odds)
            {
                Console.WriteLine($"Yes, sum = {evens}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(evens - odds)}");
            }

            Console.ReadKey();
        }
    }
}
