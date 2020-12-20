using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMaxVariations
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 4;
            int numResult = GetMax(x, y);
            Console.WriteLine(numResult);

            char a = 'j';
            char b = 'l';
            char charResult = GetMax(a, b);
            Console.WriteLine(charResult);

            string first = "FFFFFFF";
            string second = "REEEEEE";
            string strResult = GetMax(first, second);
            Console.WriteLine(strResult);

            Console.ReadKey();
        }

        static int GetMax(int a, int b)
        {
            if (b > a)
            {
                return b;
            }
            return a;
        }

        static char GetMax(char a, char b)
        {
            if (b > a)
            {
                return b;
            }
            return a;
        }

        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) < 0)
            {
                return b;
            }

            return a;
        }
    }
}
