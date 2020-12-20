using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunGlasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string midpoint = new string('|', n);
            string gap = new string(' ', n);

            int glassesWidth = n * 2;
            int innerWidth = glassesWidth - 2;

            string topBottomFrame = new string('*', glassesWidth);
            string midFrame = "*" + new string('/', innerWidth) + "*";

            Console.WriteLine(topBottomFrame + gap + topBottomFrame);
            for (int i = 1; i <= n-2; i++)
            {
                if (i == (n-1)/2)
                {
                    Console.WriteLine(midFrame + midpoint + midFrame);
                }
                else
                {
                    Console.WriteLine(midFrame + gap + midFrame);
                }
            }
            Console.WriteLine(topBottomFrame + gap + topBottomFrame);

            Console.ReadKey();
        }
    }
}
