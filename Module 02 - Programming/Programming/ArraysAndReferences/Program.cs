using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 10, 15, 20, 25 };
            // Join the elements of the array in a string,
            // seperated by a comma and space.
            Console.WriteLine($"Originals: {string.Join(", ", numbers)}");

            // Collections such as arrays are passed by
            // reference, thus changes to the array inside
            // a function persist outside as well.
            ChangeNumbers(numbers);
            Console.WriteLine($"Changed: {string.Join(", ", numbers)}");

            Console.ReadLine();
        }

        static void ChangeNumbers(int[] numsToChange)
        {
            // Get the ammount of elements an array can
            // hold, by getting it's Length.
            for (int i = 0; i < numsToChange.Length; i++)
            {
                numsToChange[i] += i * 2;
            }
        }
    }
}
