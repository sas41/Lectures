using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionAndIntersect
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> alpha = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> beta = new List<int>() { 2, 4, 6 };

        }

        static List<int> Intersect(List<int> a, List<int> b)
        {
            List<int> result = new List<int>();

            foreach (var item in a)
            {
                if (b.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        static List<int> Union(List<int> a, List<int> b)
        {
            List<int> result = new List<int>();
            result.AddRange(a);

            foreach (var item in b)
            {
                if ( ! result.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}
