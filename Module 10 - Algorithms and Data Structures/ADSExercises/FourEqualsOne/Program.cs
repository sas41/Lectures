using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourEqualsOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int test = SolveWithDataStructure(n);

            Console.WriteLine(test);
            Console.ReadLine();
        }

        static int SolveWithDataStructure(int n)
        {
            List<int> solution = new List<int>() { 1, 2, 5 };

            for (int i = 3; i <= n; i++)
            {
                int a = solution[i - 1] * 2;
                int b = solution[i - 2];
                int c = solution[i - 3];
                solution.Add(a+b+c);
            }

            return solution[n];
        }
    }
}
