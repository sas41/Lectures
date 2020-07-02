using System;
using System.Collections.Generic;
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

        static void Swap(int indexA, int indexB, List<int> input)
        {
            int temp = input[indexA];
            input[indexA] = input[indexB];
            input[indexB] = temp;
        }
    }
}
