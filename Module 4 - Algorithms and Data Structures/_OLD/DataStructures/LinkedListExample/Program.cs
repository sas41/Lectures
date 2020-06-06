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
            LinkedList<int> myList = new LinkedList<int>();

            myList.Add(10);
            myList.Add(11);

            Console.WriteLine(myList.Count());
            myList.RemoveAt(1);
            Console.WriteLine(myList.Count());

            myList.Add(12);
            myList.Add(13);
            myList.Add(14);

            Console.WriteLine(myList.Count());

            myList.RemoveAt(1);
            myList.RemoveAt(1);

            Console.WriteLine(myList.Count());

            myList.RemoveAt(0);


            Console.WriteLine(myList.Count());
            Console.ReadLine();
        }
    }
}
