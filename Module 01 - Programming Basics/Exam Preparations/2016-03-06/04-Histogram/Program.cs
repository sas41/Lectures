using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1++;
                }
                else if (num < 400)
                {
                    p2++;
                }
                else if (num < 600)
                {
                    p3++;
                }
                else if (num < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }

            double p1Percentage = ((double)p1 / (double)n) * 100;
            double p2Percentage = ((double)p2 / (double)n) * 100;
            double p3Percentage = ((double)p3 / (double)n) * 100;
            double p4Percentage = ((double)p4 / (double)n) * 100;
            double p5Percentage = ((double)p5 / (double)n) * 100;

            Console.WriteLine($"{p1Percentage:0.00}%");
            Console.WriteLine($"{p2Percentage:0.00}%");
            Console.WriteLine($"{p3Percentage:0.00}%");
            Console.WriteLine($"{p4Percentage:0.00}%");
            Console.WriteLine($"{p5Percentage:0.00}%");

            Console.ReadLine();
        }
    }
}
