using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Christmas_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int nights = int.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string roomType = Console.ReadLine();

            int costPerNight = 0;

            if (destination == "Borovets")
            {
                costPerNight = 38;
                if (roomType == "apartment")
                {
                    costPerNight = 45;
                }
            }
            else if (destination == "Bansko")
            {
                costPerNight = 35;
                if (roomType == "apartment")
                {
                    costPerNight = 42;
                }
            }
            else
            {
                costPerNight = 39;
                if (roomType == "apartment")
                {
                    costPerNight = 49;
                }
            }

            if (nights > 10)
            {
                Console.WriteLine($"They have to spend {(costPerNight * nights) * 0.85:0.00} leva.");
            }
            else
            {
                Console.WriteLine($"They have to spend {costPerNight * nights:0.00} leva.");
            }
        }
    }
}
