using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTree
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericTree<int> testTree = new GenericTree<int>(0);

            var sub1 = testTree.Root.AddOneWay(1);
            var sub2 = testTree.Root.AddOneWay(2);
            var sub3 = testTree.Root.AddOneWay(3);

            sub1.AddOneWay(11);
            sub1.AddOneWay(111);
            sub1.AddOneWay(1111);

            sub2.AddOneWay(22);
            sub2.AddOneWay(222);
            sub2.AddOneWay(2222);

            sub3.AddOneWay(33);
            sub3.AddOneWay(333);
            sub3.AddOneWay(3333);

            Console.WriteLine();
            Console.ReadLine();


        }
    }
}
