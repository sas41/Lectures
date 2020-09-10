using System;
using System.Collections.Generic;
using System.Linq;

namespace UnionIntersectEtc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = new List<int> { 0, 1, 2, 3, 4, 5 };
            List<int> second = new List<int> { 3, 4, 5, 6, 7, 8 };

            var union = Union(first, second);
            Console.WriteLine(string.Join(", ", union));

            var intersect = Intersect(first, second);
            Console.WriteLine(string.Join(", ", intersect));

            var unique = Unique(first, second);
            Console.WriteLine(string.Join(", ", unique));

            Console.ReadLine();
        }

        static List<int> Union(List<int> a, List<int> b)
        {
            List<int> c = new List<int>();
            c.AddRange(a);

            foreach (var item in b)
            {
                if (!c.Contains(item))
                {
                    c.Add(item);
                }
            }

            return c;
        }

        static List<int> Intersect(List<int> a, List<int> b)
        {
            List<int> c = new List<int>();

            foreach (var item in a)
            {
                if (b.Contains(item))
                {
                    c.Add(item);
                }
            }

            return c;
        }

        static List<int> Unique(List<int> a, List<int> b)
        {
            List<int> c = new List<int>();

            foreach (var item in a)
            {
                if (!b.Contains(item))
                {
                    c.Add(item);
                }
            }

            foreach (var item in b)
            {
                if (!a.Contains(item))
                {
                    c.Add(item);
                }
            }

            return c;
        }

    }
}
