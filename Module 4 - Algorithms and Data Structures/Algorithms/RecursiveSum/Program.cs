using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveSum
{
    class Program
    {
        static int RecSum(List<int> list)
        {
            Console.WriteLine();
            if (list.Count == 1)
            {
                Console.WriteLine($"Returning: {list[0]}");
                return list[0];
            }
            else
            {
                Console.WriteLine($"Returning: [{String.Join(", ", list.Take(list.Count / 2))}]");
                Console.WriteLine($"Returning: [{String.Join(", ", list.Skip(list.Count / 2))}]");
                return  RecSum(list.Take(list.Count / 2).ToList())
                        +
                        RecSum(list.Skip(list.Count / 2).ToList());
            }
        }

        static void Main(string[] args)
        {
            List<int> myNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Console.WriteLine(RecSum(myNumbers));

            Console.ReadLine();
        }
    }
}
