using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickestWayFromNToM
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> temp = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = temp[0], m = temp[1];

            Operation start = new Operation(n);

            Queue<Operation> sequence = new Queue<Operation>();
            sequence.Enqueue(start);

            while (n < m)
            {
                Operation current = sequence.Dequeue();

                if (current.Result == m)
                {
                    Console.WriteLine(current);
                    break;
                }

                sequence.Enqueue(new Operation(current, "+1"));
                sequence.Enqueue(new Operation(current, "+2"));
                sequence.Enqueue(new Operation(current, "*2"));
            }

            if (n > m)
            {
                Console.WriteLine("No path!");
            }

            Console.ReadLine();

        }
    }
}
