using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (var row = 1; row <= n; row++)
            {
                // Empty Spaces + Stars = n.
                int emptySpaceCount = n - row;
                int starCount = row;

                // Add required empty spaces before first star.
                string currentLine = new string(' ', emptySpaceCount);
                // First Star.
                currentLine += "*";

                // One less than starCount because we already added a star.
                for (var col = 0; col < starCount - 1; col++)
                {
                    currentLine += " *";
                }
                Console.WriteLine(currentLine);
            }

            for (int row = n - 1; row > 0; row--)
            {
                // Empty Spaces + Stars = n.
                int emptySpaceCount = n - row;
                int starCount = row;

                // Add required empty spaces before first star.
                string currentLine = new string(' ', emptySpaceCount);
                // First Star.
                currentLine += "*";

                // One less than starCount because we already added a star.
                for (var col = 0; col < starCount - 1; col++)
                {
                    currentLine += " *";
                }
                Console.WriteLine(currentLine);
            }

            Console.ReadKey();
        }
    }
}
