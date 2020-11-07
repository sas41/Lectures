using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal distance = decimal.Parse(Console.ReadLine());
            string source = Console.ReadLine();
            string destination = Console.ReadLine();

            decimal inMeters = distance;
            decimal output = distance;

            if (source == "cm")
            {
                inMeters = distance / 100;
            }
            else if (source == "mm")
            {
                inMeters = distance / 1000;
            }
            else if (source == "km")
            {
                inMeters = distance * 1000;
            }
            else if (source == "mi")
            {
                inMeters = distance / 0.000621371192m;
            }
            else if (source == "in")
            {
                inMeters = distance / 39.3700787m;
            }
            else if (source == "ft")
            {
                inMeters = distance / 3.2808399m;
            }
            else if (source == "yd")
            {
                inMeters = distance / 1.0936133m;
            }



            if (destination == "cm")
            {
                output = inMeters * 100;
            }
            else if (destination == "mm")
            {
                output = inMeters * 1000;
            }
            else if (destination == "km")
            {
                output = inMeters / 1000;
            }
            else if (destination == "mi")
            {
                output = inMeters * 0.000621371192m;
            }
            else if (destination == "in")
            {
                output = inMeters * 39.3700787m;
            }
            else if (destination == "ft")
            {
                output = inMeters * 3.2808399m;
            }
            else if (destination == "yd")
            {
                output = inMeters * 1.0936133m;
            }

            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
