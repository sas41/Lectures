using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());

            if (first > second)
            {
                Console.WriteLine("First Number is Larger");
            }
            else if ( first == second )
            {
                Console.WriteLine("Both Numbers are Equal.");
            }
            else if (first == 5)
            {
                Console.WriteLine("First Number is 5.");
            }
            else
            {
                Console.WriteLine("Second Number is Larger");
            }

            Console.WriteLine("Comparison is done.");

            if (first > second)
            {

            }

            if (first < second)
            {

            }

            if (first <= second)
            {

            }

            if (first >= second)
            {

            }

            if (first == second)
            {

            }

            if (first != second)
            {

            }

            if (!(first == second))
            {

            }

            if ( (first > second) && (first > 5) )
            {

            }

            if ( (first > second) || (first > 5) )
            {

            }

            if ( (first + second) == (first * second) )
            {

            }

            Console.ReadLine();
        }
    }
}
