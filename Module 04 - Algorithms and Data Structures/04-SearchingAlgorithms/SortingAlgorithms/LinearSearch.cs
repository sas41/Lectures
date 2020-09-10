using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SortingAlgorithms
{
    class LinearSearch
    {
        public static int Search<T>(ICollection<T> collection, T toFind)
        {
            int count = collection.Count;
            T[] col = collection.ToArray();
            for (int i = 0; i < count; i++)
            {
                if ( col[i].Equals(toFind) )
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
