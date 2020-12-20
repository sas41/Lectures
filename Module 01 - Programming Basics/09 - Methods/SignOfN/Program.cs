using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfN
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            SignOf(input);

            Console.ReadKey();
        }

        static void SignOf(int n)
        {
            if (n == 0)
            {
                Console.WriteLine($"The number is 0.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The sign of {n} is Negative!");
            }
            else
            {
                Console.WriteLine($"The sign of {n} is Positive!");
            }
        }
    }
}
