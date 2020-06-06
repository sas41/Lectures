using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> set = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> longest = new List<int>();
            Stack<int> current = new Stack<int>();

            foreach (var number in set)
            {
                if (current.Count == 0 || current.Peek() != number)
                {
                    if (current.Count > longest.Count)
                    {
                        longest = current.ToList();
                    }
                    current.Clear();
                }

                current.Push(number);
            }

            Console.WriteLine(String.Join("", longest));

            Console.ReadKey();
        }
    }
}
