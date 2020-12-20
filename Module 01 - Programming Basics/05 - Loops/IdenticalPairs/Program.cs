using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdenticalPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int lowestSum = a + b;
            int highestSum = a + b;

            for (int i = 1; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());

                int currentAB = a + b;

                if (currentAB != lowestSum || currentAB != highestSum )
                {
                    lowestSum = Math.Min(lowestSum, currentAB);
                    highestSum = Math.Max(highestSum, currentAB);
                }
            }

            if (lowestSum != highestSum)
            {
                Console.WriteLine($"No, maxdiff = {highestSum - lowestSum}");
            }
            else
            {
                Console.WriteLine($"Yes, value = {highestSum}");
            }

            Console.ReadKey();
        }
    }
}
