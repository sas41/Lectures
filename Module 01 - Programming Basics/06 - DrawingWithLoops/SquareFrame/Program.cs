using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string midLines = "";
            for (int i = 0; i < n-2; i++)
            {
                midLines = midLines + " -";
            }

            string topAndBottom = "+" + midLines + " +";
            string midRows = "|" + midLines + " |";

            Console.WriteLine(topAndBottom);
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine(midRows);
            }
            Console.WriteLine(topAndBottom);

            Console.ReadKey();
        }
    }
}
