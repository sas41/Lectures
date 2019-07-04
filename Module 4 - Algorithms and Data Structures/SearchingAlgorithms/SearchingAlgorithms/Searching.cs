using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms
{
    class Searching
    {

        private static bool Less(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }

        public static bool Equal<T>(T first, T second)
        {
            // Basically returns set[i] == item, but for generic types
            return EqualityComparer<T>.Default.Equals(first, second);
        }

        public static int LinearSearch<T>(List<T> set, T item)
        {
            for (int i = 0; i < set.Count; i++)
            {
                // Basically, if (set[i] == item)
                if (Equal(set[i], item))
                {
                    return i;
                }
            }
            return -1;
        }

        public static int BinarySearch<T>(List<T> set, T item) where T : IComparable
        {
            int start = 0; // First Index
            int end = set.Count - 1; // Last Index
            int median = set.Count / 2;

            while (start != median && end != median)
            {
                if (Equal(set[median], item))
                {
                    return median;
                }
                else if (Less(set[median], item))
                {
                    start = median;
                }
                else
                {
                    end = median;
                }

                median = start + ((end - start) / 2);
            }

            return -1;
        }

        // TODO: Finish Fibonacci Search
        public static int FibonacciSearch<T>(List<T> set, T item) where T : IComparable
        {
            int fib1 = 0, fib2 = 1, fibN = fib1 + fib2;

            // Find the first Fibonacci number
            // greater or equal to the last index
            while (fibN < set.Count)
            {
                fib1 = fib2;
                fib2 = fibN;
                fibN = fib1 + fib2;
            }

            int start = 0; // First Index
            int end = set.Count - 1; // Last Index

            return -1;
        }

    }
}
