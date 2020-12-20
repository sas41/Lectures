using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XToThePowerOfY
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int result = Power(x, y);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        static int Power(int x, int y)
        {
            int result = 1;

            for (int i = 0; i < y; i++)
            {
                result = result * x;
            }

            return result;
        }
    }
}
