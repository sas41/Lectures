using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signatures
{
    static class MathHelper
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static double Add(int a, double b)
        {
            return a + b;
        }
        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public static double Power(double number, int pow = 2)
        {
            pow = Math.Abs(pow);
            double result = 1;

            if (pow == 1)
            {
                result = number;
            }
            else if(pow > 1)
            {
                result = number;
                for (int i = 0; i < pow; i++)
                {
                    result = result * number;
                }
            }

            return result;
        }

    }
}
