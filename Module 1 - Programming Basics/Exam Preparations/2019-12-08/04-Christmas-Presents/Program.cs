using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Christmas_Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            int kids = int.Parse(Console.ReadLine());

            int lego = 0;
            int monopoly = 0;
            int puzzle = 0;
            int robot = 0;

            for (int i = 0; i < kids; i++)
            {
                string gift = Console.ReadLine();

                if (gift == "lego")
                {
                    lego++;
                }
                else if (gift == "monopoly")
                {
                    monopoly++;
                }
                else if (gift == "puzzle")
                {
                    puzzle++;
                }
                else
                {
                    robot++;
                }
            }

            Console.WriteLine($"Lego: {((double)lego/ (double)kids) * 100:0.00}%");
            Console.WriteLine($"Monopoly: {((double)monopoly / (double)kids) * 100:0.00}%");
            Console.WriteLine($"Puzzles: {((double)puzzle / (double)kids) * 100:0.00}%");
            Console.WriteLine($"Robots: {((double)robot / (double)kids) * 100:0.00}%");
        }
    }
}
