using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class SelectionSort
    {
        public static List<int> Sort(List<int> input)
        {
            List<int> current = new List<int>(input);
            int n = current.Count;
            int lowest = 0;

            for (int i = 0; i < n; i++)
            {
                lowest = i;
                
                for (int j = i+1; j < n; j++)
                {
                    if (current[j] < current[lowest])
                    {
                        lowest = j;
                    }
                }

                Swap(i, lowest, current);

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
