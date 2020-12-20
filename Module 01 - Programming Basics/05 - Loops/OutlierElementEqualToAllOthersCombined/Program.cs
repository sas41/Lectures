using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlierElementEqualToAllOthersCombined
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = int.Parse(Console.ReadLine());
            int highest = sum;

            for (int i = 1; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                sum += input;

                if (input > highest)
                {
                    highest = input;
                }

            }

            sum = sum - highest;
            if (sum == highest)
            {
                Console.WriteLine($"Yes, sum = {sum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum - highest)}");
            }

            Console.ReadKey();
        }
    }
}
