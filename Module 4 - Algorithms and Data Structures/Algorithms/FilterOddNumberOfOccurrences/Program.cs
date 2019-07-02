using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterOddNumberOfOccurrences
{
    class Program
    {
        static void MethodOne()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (var num in numbers)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict.Add(num, 1);
                }
            }

            foreach (var kvp in dict)
            {
                if (kvp.Value % 2 != 0)
                {
                    //numbers.RemoveAll(x => x == kvp.Key);
                    while (numbers.Contains(kvp.Key))
                    {
                        numbers.Remove(kvp.Key);
                    }
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }

        static void MethodTwo()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> filtered = new List<int>();

            foreach (var num in numbers)
            {
                int count = 0;
                foreach (var innerNum in numbers)
                {
                    if (num == innerNum)
                    {
                        count++;
                    }
                }

                if (count % 2 == 0)
                {
                    filtered.Add(num);
                }
            }

            Console.WriteLine(String.Join(" ", filtered));
        }

        static void Main(string[] args)
        {
            MethodOne();
            //MethodTwo();
        }
    }
}
