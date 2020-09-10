using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine().ToLower();
            bool isNight = timeOfDay == "night";

            double taxiCost = 0.70 + TaxiCost(n, isNight);
            double busCost = n * 0.09;
            double trainCost = n * 0.06;

            if (n < 20)
            {
                Console.WriteLine(taxiCost);
            }
            else if (n < 100)
            {
                Console.WriteLine(busCost);
            }
            else
            {
                Console.WriteLine(trainCost);
            }

            Console.ReadLine();
        }

        static double TaxiCost(int kilometers, bool isNight)
        {
            if (isNight)
            {
                return kilometers * 0.9;
            }
            else
            {
                return kilometers * 0.79;
            }
        }

    }
}
