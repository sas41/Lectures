using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.Add(5);
            linkedList.Add(6);
            linkedList.Add(12);
            linkedList.Add(77);
            linkedList.Add(88);

            linkedList.Remove(6);
            linkedList.Remove(77);
            linkedList.Add(99);
            linkedList[1] = 33;
            linkedList.RemoveAt(2);
            Console.WriteLine(linkedList.Remove(5));


            LinkedList<int> test = new LinkedList<int>();

            for (int i = 0; i < 10; i++)
            {
                test.Add(i);
            }

            for (int i = 0; i < test.Count; i++)
            {
                Console.WriteLine(test[i]);
            }

            test.Reverse();
            Console.WriteLine();

            for (int i = 0; i < test.Count; i++)
            {
                Console.WriteLine(test[i]);
            }


            Console.ReadLine();
        }
    }
}
