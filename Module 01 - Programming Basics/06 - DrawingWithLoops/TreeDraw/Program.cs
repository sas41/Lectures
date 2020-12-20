using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDraw
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string trunk = " | ";

            for (int i = 0; i <= n; i++)
            {
                int emptySpaceCount = n - i;
                int starCount = i;

                string spaces = new string(' ', emptySpaceCount);
                string stars = new string('*', starCount);

                string line = spaces + stars + trunk + stars + spaces;

                Console.WriteLine(line);
            }

            Console.ReadKey();
        }
    }
}
