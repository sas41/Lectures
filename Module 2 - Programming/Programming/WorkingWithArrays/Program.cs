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
            //ReadAndWrite();
            ReverseSortClear();
            CopyCopyTo();

            Console.ReadLine();
        }

        static void ReadAndWrite()
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
        }

        static void ReverseSortClear()
        {
            Console.WriteLine();

            int[] numbers = new int[] { 2, 4, -5, 1, 10 };
            Console.WriteLine("Numbers (Default): " + string.Join(", ", numbers));

            Array.Reverse(numbers);
            Console.WriteLine("Numbers (Reverse): " + string.Join(", ", numbers));

            Array.Sort(numbers);
            Console.WriteLine("Numbers (Sorted): " + string.Join(", ", numbers));

            Array.Sort(numbers);
            Array.Reverse(numbers);
            Console.WriteLine("Numbers (Sort-Reverse): " + string.Join(", ", numbers));

            Array.Clear(numbers,0, 3);
            Console.WriteLine("Numbers (Clear(numbers, 0, 3)): " + string.Join(", ", numbers));

            Console.WriteLine();
        }

        static void CopyCopyTo()
        {
            Console.WriteLine();

            int[] source = new int[] { 2, 4, 6, 8, 10, 12, 14, 16 };
            int[] destination = new int[] { 1, 3, 5, 7, 9, 11, 13, 15 };
            Console.WriteLine("Source: " + string.Join(", ", source));
            Console.WriteLine("Destination: " + string.Join(", ", destination));

            Console.WriteLine();

            Array.Copy(source, 4, destination, 2, 3);
            Console.WriteLine("Command = Array.Copy(source, 4, destination, 2, 3)");
            Console.WriteLine("Destination: " + string.Join(", ", destination));

            Console.WriteLine();

            source.CopyTo(destination, 0);
            Console.WriteLine("Command = source.CopyTo(destination, 0)");
            Console.WriteLine("Destination: " + string.Join(", ", destination));

            Console.WriteLine();
        }
    }
}
