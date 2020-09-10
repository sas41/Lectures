using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseOrderUsingAStack
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numsList = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> nums = new Stack<int>();

            foreach (var num in numsList)
            {
                nums.Push(num);
            }

            Console.WriteLine("Reverse order:");

            while (nums.Count > 0)
            {
                int printNum = nums.Pop();
                Console.Write(printNum + " ");
            }

            Console.WriteLine();
        }
    }
}
