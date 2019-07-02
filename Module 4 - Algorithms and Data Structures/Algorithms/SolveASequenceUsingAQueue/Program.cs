using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveASequenceUsingAQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> mainQueue = new Queue<int>();
            mainQueue.Enqueue(n);

            for (int i = 0; i < 50; i++)
            {
                Console.Write(mainQueue.Peek() + ", ");
                int current = mainQueue.Dequeue();

                mainQueue.Enqueue(current + 1);
                mainQueue.Enqueue(2* current + 1);
                mainQueue.Enqueue(current + 2);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
