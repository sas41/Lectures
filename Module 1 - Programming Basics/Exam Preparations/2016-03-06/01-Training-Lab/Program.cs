using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            const double workSpaceHeight = 1.20;
            const double workSpaceWidth = 0.70;
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());

            // Коридора е 100cm (1м).
            w = w - 1.0;

            int columns = (int)(h / workSpaceHeight);
            int rows = (int)(w / workSpaceWidth);
            int workspaces = columns * rows;

            // Вратата е голям колкото едно работно място.
            workspaces = workspaces - 1;

            // Катедрата отнема 2 места.
            workspaces = workspaces - 2;

            Console.WriteLine(workspaces);

        }
    }
}
