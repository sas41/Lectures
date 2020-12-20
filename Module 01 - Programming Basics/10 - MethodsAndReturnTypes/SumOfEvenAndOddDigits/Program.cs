using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfEvenAndOddDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int result = SumOfDigits(input);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        static int SumOfDigits(int number)
        {
            number = Math.Abs(number);
            int evens = SumEvens(number);
            int odds = SumOdds(number);

            return evens * odds;
        }

        static int SumEvens(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int current = number % 10;
                if (current % 2 == 0)
                {
                    sum += current;
                }
                number = number / 10;
            }
            return sum;
        }

        static int SumOdds(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int current = number % 10;
                if (current % 2 != 0)
                {
                    sum += current;
                }
                number = number / 10;
            }
            return sum;
        }
    }
}
