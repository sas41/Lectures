using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Sorting
    {

        private static bool Less(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }

        private static void Swap<T>(List<T> list, int from, int to)
        {
            T container = list[to];
            list[to] = list[from];
            list[from] = container;
        }

        public static List<T> SelectionSort<T>(List<T> inputList) where T : IComparable
        {
            List<T> collection = new List<T>();
            collection.AddRange(inputList);

            for (int i = 0; i < collection.Count; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (Less(collection[j], collection[minIndex]))
                    {
                        minIndex = j;
                    }
                }
                Swap(collection, i, minIndex);
            }

            return collection;
        }

        public static List<T> BubbleSort<T>(List<T> inputList) where T : IComparable
        {
            List<T> collection = new List<T>();
            collection.AddRange(inputList);

            for (int i = 1; i < collection.Count - 1; i++)
            {
                for (int j = 0; j < collection.Count - i; j++)
                {
                    if (Less(collection[j+1], collection[j]))
                    {
                        //Swap
                        Swap(collection, j, j+1);
                    }
                }
            }

            return collection;
        }

        public static List<T> InsertionSort<T>(List<T> inputList) where T : IComparable
        {
            List<T> collection = new List<T>();
            collection.AddRange(inputList);

            for (int i = 0; i < collection.Count - 1; i++)
            {
                if (Less(collection[i + 1], collection[i]))
                {
                    for (int j = i + 1; j > 0; j--)
                    {
                        if (Less(collection[j], collection[j - 1]))
                        {
                            //Swap
                            Swap(collection, j, j - 1);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            return collection;
        }

        public static List<T> MergeSort<T>(List<T> l1) where T : IComparable
        {
            int count = l1.Count;
            List<T> A = l1.Take(count / 2).ToList();
            List<T> B = l1.Skip(count / 2).ToList();

            if (count > 2)
            {
                l1 = Merge(MergeSort(A).ToList(), MergeSort(B).ToList()).ToList();
            }
            else
            {
                l1 = Merge(A, B).ToList();
            }

            return l1;
        }

        private static List<T> Merge<T>(List<T> l1, List<T> l2) where T : IComparable
        {
            l1.AddRange(l2);
            l1.Sort();
            return l1;
        }

        public static List<T> QuickSort<T>(List<T> inputList, int startIndex = -1, int endIndex = -1) where T : IComparable
        {
            // TODO: Fix this mess.
            List<T> collection = new List<T>();
            collection.AddRange(inputList);

            if (startIndex == -1 || endIndex == -1)
            {
                startIndex = 0;
                endIndex = collection.Count - 1;
            }

            int i = startIndex, j = endIndex;

            T pivot = collection[(startIndex + endIndex) / 2];

            while (i <= j)
            {
                while (Less(collection[i], pivot))
                {
                    i++;
                }

                while (Less(collection[j], pivot))
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap and Increment / Decrement
                    Swap(collection, i, j);
                    i++;
                    j--;
                }
            }

            // Recursive calls for first half and second half
            if (startIndex < j)
            {
                collection = QuickSort(collection, startIndex, j).ToList();
            }

            if (i < endIndex)
            {
                collection = QuickSort(collection, i, endIndex).ToList();
            }

            return collection;
        }
    }
}
