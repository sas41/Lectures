using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetPaving
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> lengths = Console.ReadLine().Split().Select(int.Parse).ToList();
            lengths = lengths.Where(x => x > 0).ToList(); // Remove 0 or less lengths

            List<int> solutions = new List<int>() { 1, 1 };

            // i = 2 because the first step is at least 
            for (int i = 2; i <= n; i++)
            {
                int num = 0;
                foreach (int index in lengths)
                {
                    if (i - index >= 0)
                    {
                        num += solutions[i - index];
                    }
                }
                solutions.Add(num);
            }

            Console.WriteLine(solutions.Last());
            Console.ReadLine();
        }
    }
}
