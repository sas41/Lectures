using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciDP
{
    class Program
    {
        static List<int> Fibs;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Fibs = (new int[n+1]).ToList();

            Fibs[1] = 1;
            Fibs[2] = 1;

            FibGood(n);
            Console.WriteLine(string.Join(" ", Fibs.Skip(1)));

            Console.WriteLine();
            Console.WriteLine();


            int bad = FibBad(n);
            Console.WriteLine(bad);

            Console.ReadLine();
        }

        static int FibGood(int n)
        {
            if (n<=2)
            {
                return 1;
            }
            else if (Fibs[n] != 0)
            {
                return Fibs[n];
            }

            int nm1 = FibGood(n - 1);
            int nm2 = FibGood(n - 2);

            Fibs[n] = nm1 + nm2;

            return nm1 + nm2;
        }


        static int FibBad(int n)
        {
            if (n <= 2)
            {
                return 1;
            }

            int nm1 = FibBad(n - 1);
            int nm2 = FibBad(n - 2);

            return nm1 + nm2;
        }
    }
}
