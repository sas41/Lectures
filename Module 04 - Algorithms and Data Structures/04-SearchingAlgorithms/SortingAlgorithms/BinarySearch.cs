using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms
{
    class BinarySearch
    {
        public static int Search<T>(ICollection<T> collection, T toFind) where T : IComparable
        {
            int beginning = 0;
            int end = collection.Count - 1;
            T[] col = collection.ToArray();

            int mid;

            while (beginning != end && beginning < end)
            {
                //Find Middle
                mid = ((end - beginning) / 2) + beginning;
                if (col[mid].CompareTo(toFind) == 0)
                {
                    return mid;
                }
                else if (col[mid].CompareTo(toFind) == -1)
                {
                    beginning = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }


            return -1;
        }
    }
}
