using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Christmas_Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double breadCost = double.Parse(Console.ReadLine());
            double sweetbreadCost = breadCost * 1.20;
            double bagelCost = sweetbreadCost * 0.6;
            double croissantCost = bagelCost + 1.2;


            int breadCount = int.Parse(Console.ReadLine());
            int sweetbreadCount = int.Parse(Console.ReadLine());
            int bagelCount = int.Parse(Console.ReadLine());
            int croissantCount = int.Parse(Console.ReadLine());

            double budget = double.Parse(Console.ReadLine());

            double total = breadCost * breadCount;
            total += sweetbreadCost * sweetbreadCount;
            total += bagelCost * bagelCount;
            total += croissantCost * croissantCount;

            if (total > budget)
            {
                Console.WriteLine($"No! {total - budget:0.00} leva need.");
            }
            else
            {
                Console.WriteLine($"Yes! {budget - total:0.00} leva left.");
            }
        }
    }
}
