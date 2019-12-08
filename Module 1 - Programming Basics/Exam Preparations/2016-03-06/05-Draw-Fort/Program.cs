using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int halfN = (n / 4) * 2;
            string horizontalWall = new string('_', halfN);

            int edgeWidth = (int)Math.Ceiling((decimal)((n * 2) - halfN) / 2);

            // Top
            string topSide = "/" + new string('^', edgeWidth - 2) + "\\";
            string top = topSide + topSide;
            if (n > 4)
            {
                top = topSide + horizontalWall + topSide;
            }

            Console.WriteLine(top);

            // Middle
            int middleRowCount = n - 2 - 1;
            string middleRow = "|" + new string(' ', (n * 2) - 2) + "|";
            for (int i = 0; i < middleRowCount; i++)
            {
                Console.WriteLine(middleRow);
            }

            if (n > 4)
            {
                int specialSpaceCount = ((n * 2) - 2 - halfN) / 2;
                string specialSpace = new string(' ', specialSpaceCount);
                string special = "|" + specialSpace + horizontalWall + specialSpace + "|";
                Console.WriteLine(special);
            }
            else
            {
                Console.WriteLine(middleRow);
            }

            // Bottom
            string bottomMiddle = new string(' ', halfN);
            string bottomSide = "\\" + new string('_', edgeWidth - 2) + "/";
            string bottom = bottomSide + bottomSide;
            if (n > 4)
            {
                bottom = bottomSide + bottomMiddle + bottomSide;
            }

            Console.WriteLine(bottom);

            Console.ReadLine();
        }
    }
}
