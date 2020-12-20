using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdenticalPairsAlt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int lastSum = a + b;
            int highestDiff = 0;

            for (int i = 1; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());

                int currentSum = a + b;
                int currentDiff = Math.Abs(currentSum - lastSum);
                highestDiff = Math.Max(highestDiff, currentDiff);
                lastSum = currentSum;
            }

            if (highestDiff != 0)
            {
                Console.WriteLine($"No, maxdiff = {highestDiff}");
            }
            else
            {
                Console.WriteLine($"Yes, value = {lastSum}");
            }

            Console.ReadKey();

        }
    }
}
