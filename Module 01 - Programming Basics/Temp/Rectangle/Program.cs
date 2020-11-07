using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool inside = (x > x1 && x < x2 && y > y1 && y < y2);

            bool wall_LeftRight = ( (x == x1 || x == x2) && (y >= y1 && y <= y2) );
            bool wall_TopBottom = ( (y == y1 || y == y2) && (x >= x1 && x <= x2) );

            bool wall = ( wall_TopBottom || wall_LeftRight );

            if (inside)
            {
                Console.WriteLine("Inside");
            }
            else if (wall)
            {
                Console.WriteLine("Wall");
            }
            else
            {
                Console.WriteLine("Outside");
            }

            Console.WriteLine();
        }
    }
}
