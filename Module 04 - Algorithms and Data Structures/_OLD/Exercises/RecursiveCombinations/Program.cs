using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveCombinations
{
    class Program
    {
        public static void PrintCombinations(int k, int n, List<int> inputList)
        {
            List<int> list = new List<int>();
            list.AddRange(inputList);

            if (list.Count < k)
            {
                if (list.Count == 0)
                {
                    list.Add(0);
                }
                else
                {
                    list.Add(list[list.Count - 1] - 1);
                }

                for (int i = list[list.Count - 1]; i < n; i++)
                {
                    list[list.Count - 1]++;
                    PrintCombinations(k, n, list);
                }
            }
            else
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }

        static void Main(string[] args)
        {
            PrintCombinations(3, 3, new List<int>());
            Console.ReadLine();
        }
    }
}
