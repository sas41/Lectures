using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double result = FindArea(width, height);

            Console.WriteLine(result) ;

            Console.ReadKey();
        }

        static double FindArea(int w, int h)
        {
            return w * h / 2.0;
        }
    }
}
