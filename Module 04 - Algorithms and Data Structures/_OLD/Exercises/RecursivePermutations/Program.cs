using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursivePermutations
{

    class Program
    {
        public static void PrintPermutations(int n, List<int> inputList)
        {
            List<int> list = new List<int>();
            list.AddRange(inputList);

            if (list.Count < n)
            {
                list.Add(0);
                for (int i = 1; i <= n; i++)
                {
                    list[list.Count - 1]++;
                    PrintPermutations(n, list);
                }
            }
            else
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }

        static void Main(string[] args)
        {
            PrintPermutations(3, new List<int>());
            Console.ReadLine();
        }
    }
}
