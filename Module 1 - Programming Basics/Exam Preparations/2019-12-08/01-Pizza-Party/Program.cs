using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Pizza_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double pizza = n * 2;
            double drinks = pizza * 0.85;
            double boardgames = (pizza + drinks) / 7;

            double total = pizza + drinks + boardgames + n;

            Console.WriteLine($"{total:0.00}");
        }
    }
}
