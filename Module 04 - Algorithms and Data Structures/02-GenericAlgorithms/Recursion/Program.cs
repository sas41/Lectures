using System;
using System.Diagnostics;
using System.Linq;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 8, 6, 4, 9, 3 };
            
            int sum = RecursiveSum(array);
            Console.WriteLine(sum);

            ulong fac = RecursiveFactorial(50);
            Console.WriteLine(fac);

            ulong fac2 = Factorial(50);
            Console.WriteLine(fac2);

            DrawTwoPyramids(5);

            Console.ReadLine();
        }

        static int RecursiveSum(int[] arr)
        {
            if (arr.Length == 1)
            {
                return arr[0];
            }
            else
            {
                return arr[0] + RecursiveSum(arr.Skip(1).ToArray());
            }
        }

        static ulong RecursiveFactorial(ulong num)
        {
            if (num == 2)
            {
                return 2;
            }
            else
            {
                return num * RecursiveFactorial(num - 1);
            }
        }

        static ulong Factorial(ulong num)
        {
            ulong sum = num;

            for (ulong i = num-1; i >= 2; i--)
            {
                sum = sum * i;
            }

            return sum;
        }

        static void DrawTwoPyramids(int num)
        {
            if (num == 0)
            {
                return;
            }

            string top = new string('*', num);
            string bot = new string('#', num);

            Console.WriteLine(top);

            DrawTwoPyramids(num - 1);

            Console.WriteLine(bot);
        }
    }
}
