using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            height = height - 1;


            // 11m / 1.2 = 9;
            // 6 /  0.7 = 8;

            double columns = Math.Floor(width / 1.20);
            double rows    = Math.Floor(height / 0.70);

            double totalSeats = columns * rows;

            totalSeats = totalSeats -1 -2;

            Console.WriteLine(totalSeats);

            Console.ReadKey();
        }
    }
}
