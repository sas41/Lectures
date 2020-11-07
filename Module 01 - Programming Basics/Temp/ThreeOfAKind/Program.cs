using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeOfAKind
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string input;

            input = Console.ReadLine();
            a = double.Parse(input);

            input = Console.ReadLine();
            b = double.Parse(input);

            input = Console.ReadLine();
            c = double.Parse(input);

            bool aIsB = (a == b);
            bool bisC = (b == c);
            //               True     AND      True  => True
            //               True     AND      False => False
            //               False    AND      True  => False
            //               False    AND      False => False

            //               True      OR      True  => True
            //               True      OR      False => True
            //               False     OR      True  => True
            //               False     OR      False => False

            bool both = (aIsB == true) && (bisC == true);

            // (A == B) && (A == C) && (A == D) && (A == E)


            if (both)
            {
                Console.WriteLine("yes - all three are equal.");
            }
            else
            {
                Console.WriteLine("no - the numbers are different.");
            }

            Console.ReadKey();
        }
    }
}
