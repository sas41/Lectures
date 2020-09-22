using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
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

            PrintBinaryTree(test.Root);
            InvertBinaryTree(test.Root);
            Console.WriteLine();
            PrintBinaryTree(test.Root);

            Console.WriteLine();
            Console.ReadLine();
        }

        static void PrintBinaryTree(BinaryTreeNode<int> input)
        {
            if (input != null)
            {
                Console.WriteLine($"Node: {input.Value}, Rank: {input.GetDepth()}");
                PrintBinaryTree(input.Left);
                PrintBinaryTree(input.Right);
            }
        }

        static void InvertBinaryTree(BinaryTreeNode<int> input)
        {
            if (input != null)
            {
                InvertBinaryTree(input.Left);
                InvertBinaryTree(input.Right);
                var temp = input.Left;
                input.Left = input.Right;
                input.Right = temp;
            }
        }
    }
}
