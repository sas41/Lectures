using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms
{
    class BubbleSort
    {
        public static List<int> Sort(List<int> input)
        {
            List<int> current = new List<int>(input);
            int n = current.Count;
            bool swapped;

            for (int i = 0; i < n; i++)
            {
                swapped = false;

                for (int j = 1; j < n-i; j++)
                {
                    int left = current[j - 1];
                    int right = current[j];

                    if (left > right)
                    {
                        Swap(j - 1, j, current);
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    return current;
                }
            }

            return current;
        }

        static void Swap<T>(int indexA, int indexB, List<T> input)
        {
            T temp = input[indexA];
            input[indexA] = input[indexB];
            input[indexB] = temp;
        }

        public static ICollection<T> GenericSort<T>(ICollection<T> input) where T : IComparable
        {
            List<T> current = input.ToList();
            int n = current.Count;
            bool swapped;

            for (int i = 0; i < n; i++)
            {
                swapped = false;

                for (int j = 1; j < n - i; j++)
                {
                    T left = current[j - 1];
                    T right = current[j];

                    if (left.CompareTo(right) == 1)
                    {
                        Swap(j - 1, j, current);
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    return current;
                }
            }

            return current;
        }
    }
}
