using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_WinnerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1111; i < 10000; i++)
            {
                int d1 = i / 1000;
                int d2 = (i / 100) % 10;
                int d3 = (i / 10) % 10;
                int d4 = i % 10;
                if (d1 != 0 && d2 != 0 && d3 != 0 && d4 != 0)
                {
                    if (d1 + d2 == n && d3 % 2 == 0 && (d4 == 3 || d4 == 6))
                    {
                        count++;
                        Console.Write($"{i} ");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Count of winner numbers: {count}");
        }
    }
}
