using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];

            // Reading from console with a loop.
            for (int i = 0; i < 10; i++)
            {
                names[i] = Console.ReadLine();
            }

            // Writing to console with a loop.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Array Element {i} = {names[i]}");
            }

            Console.ReadLine();
        }
    }
}
