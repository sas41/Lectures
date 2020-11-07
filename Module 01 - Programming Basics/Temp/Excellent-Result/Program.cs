using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double grade = double.Parse(input);

            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent Grade!");
            }
            else
            {
                Console.WriteLine("Not so excellent grade.");
            }
        }
    }
}
