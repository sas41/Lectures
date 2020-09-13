using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> test = new BinaryTree<int>(20);
            test.Add(10);
            test.Add(30);
            test.Add(15);
            test.Add(16);
            test.Add(5);

            Console.WriteLine();
        }
    }
}
