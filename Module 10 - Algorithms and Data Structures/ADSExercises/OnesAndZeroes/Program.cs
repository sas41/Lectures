using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnesAndZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //int test = SolveWithRecursion(n);
            //int test = SolveWithDataStructure(n);
            int test = SolveWithLoop(n);

            Console.WriteLine(test);
            Console.ReadLine();
        }

        static int SolveWithRecursion(int n)
        {
            if (n < 3)
            {
                return n==1 ? 2 : 3;
            }
            return SolveWithRecursion(n - 1) + SolveWithRecursion(n - 2);
        }

        static int SolveWithDataStructure(int n)
        {
            List<int> solution = new List<int>() { 2, 3 };

            for (int i = 2; i <= n; i++)
            {
                int solveForI = solution.Skip(i-2).Take(2).Sum();
                solution.Add(solveForI);
            }

            return solution[n-1];
        }

        static int SolveWithLoop(int n)
        {
            if (n < 3)
            {
                return n == 1 ? 2 : 3;
            }

            int a = 2; // n-2
            int b = 3; // n-1

            for (int i = 2; i < n; i++)
            {
                int current = a + b; // find n
                a = b;
                b = current;
            }

            return b;
        }

    }
}
