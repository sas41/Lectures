using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            string product = Console.ReadLine().ToLower();
            double ammount = double.Parse(Console.ReadLine());

            double price = 0;

            if (city == "sofia")
            {
                Console.WriteLine();
                switch (product)
                {
                    case "coffee":
                        price = ammount * 0.50;
                        break;
                    case "water":
                        price = ammount * 0.80;
                        break;
                    case "beer":
                        price = ammount * 1.20;
                        break;
                    case "sweets":
                        price = ammount * 1.45;
                        break;
                    case "peanuts":
                        price = ammount * 1.60;
                        break;
                    default:
                        break;
                }
            }
            else if (city == "plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        price = ammount * 0.40;
                        break;
                    case "water":
                        price = ammount * 0.70;
                        break;
                    case "beer":
                        price = ammount * 1.15;
                        break;
                    case "sweets":
                        price = ammount * 1.30;
                        break;
                    case "peanuts":
                        price = ammount * 1.50;
                        break;
                    default:
                        break;
                }
            }
            else if (city == "varna")
            {
                switch (product)
                {
                    case "coffee":
                        price = ammount * 0.45;
                        break;
                    case "water":
                        price = ammount * 0.70;
                        break;
                    case "beer":
                        price = ammount * 1.10;
                        break;
                    case "sweets":
                        price = ammount * 1.35;
                        break;
                    case "peanuts":
                        price = ammount * 1.55;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("???");
            }

            Console.WriteLine(price);
            Console.ReadLine();
        }
    }
}
