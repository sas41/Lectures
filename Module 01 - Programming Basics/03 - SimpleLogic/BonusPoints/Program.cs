using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num = int.Parse(input);
            int bonus = 0;

            if (num <= 100)
            {
                bonus = 5;
            }
            else if (num > 1000)
            {
                bonus = num / 10;
            }
            else
            {
                bonus = num / 5;
            }

            if (num % 2 == 0)
            {
                bonus++;
            }
            else if (num % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine($"Bonus: {bonus}");
            Console.WriteLine($"Total: {bonus + num}");
            Console.ReadKey();
        }
    }
}
