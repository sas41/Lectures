using System;
using System.Collections.Generic;

namespace Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> test = new List<int> { 1, 1, 1, 2, 2, 3, 3, 3, 3, 5, 5, 6, 6, 6, 6, 6 };
            var ls = LongestEqualEasy(test);
            Console.WriteLine(string.Join(", ", ls));

            Console.ReadLine();
        }

        static List<int> LongestEqualEasy(List<int> list)
        {
            List<int> longest = new List<int>();
            List<int> current = new List<int>();
            current.Add(list[0]);

            for (int i = 1; i < list.Count; i++)
            {
                if (current[0] == list[i])
                {
                    current.Add(list[i]);
                }
                else
                {
                    if (current.Count > longest.Count)
                    {
                        longest = current;
                    }
                    current = new List<int>();
                    current.Add(list[i]);
                }
            }

            if (current.Count > longest.Count)
            {
                longest = current;
            }

            return longest;
        }
    }
}
