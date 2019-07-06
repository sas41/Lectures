using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFactorial
{
    class Program
    {
        static ulong Factorial(int f)
        {
            if (f == 0)
            {
                return 1;
            }

            return Factorial(f - 1) * (ulong) f;
        }

        static ulong IterativeFactorial(int f)
        {
            ulong res = 1;
            for (int i = 1; i <= f; i++)
            {
                res = res * (ulong) i;
            }
            return res;
        }

        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            //ulong factorial = Factorial(number);
            ulong factorial = IterativeFactorial(number);
            Console.WriteLine(factorial);

            Console.ReadLine();
        }
    }
}
