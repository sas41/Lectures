using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftSumRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int left = 0, right = 0;

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                left += current;
            }

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                right += current;
            }

            if (left == right)
            {
                Console.WriteLine($"Yes, sum = {left}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(right - left)}");
            }

            Console.ReadKey();
        }
    }
}
