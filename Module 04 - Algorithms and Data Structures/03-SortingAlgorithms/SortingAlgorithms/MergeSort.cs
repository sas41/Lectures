using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms
{
    class MergeSort
    {
        public static List<int> Sort(List<int> input)
        {
            return MergeSortRecurse(input);
        }

        static List<int> MergeSortRecurse(List<int> input)
        {
            int midPoint = input.Count / 2;

            List<int> A = input.Take(midPoint).ToList();
            List<int> B = input.Skip(midPoint).ToList();

            if (midPoint > 2)
            {
                return Merge(MergeSortRecurse(A), MergeSortRecurse(B));
            }
            else
            {
                return Merge(A, B);
            }
        }

        static List<int> Merge(List<int> a, List<int> b)
        {
            List<int> result = new List<int>();

            while (a.Count != 0 || b.Count != 0)
            {
                if (a.Count == 0)
                {
                    result.AddRange(b);
                    b.Clear();
                    break;
                }
                else if (b.Count == 0)
                {
                    result.AddRange(a);
                    a.Clear();
                    break;
                }
                else if (a[0] < b[0])
                {
                    result.Add(a[0]);
                    a.RemoveAt(0);
                }
                else if (a[0] > b[0])
                {
                    result.Add(b[0]);
                    b.RemoveAt(0);
                }
            }

            return result;
        }
    }
}
