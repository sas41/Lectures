using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class InsertionSort
    {
        public static List<int> Sort(List<int> input)
        {
            List<int> current = new List<int>(input);
            int n = current.Count;

            for (int i = 1; i < n; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    if (current[j] < current[j - 1])
                    {
                        Swap(j, j - 1, current);
                    }
                    else
                    {
                        break;
                    }
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
