using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTreeNode<T> where T : IComparable<T>
    {

        public BinaryTreeNode<T> Parent { get; set; }

        public T Value { get; set; }

        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode(T value, BinaryTreeNode<T> parent)
        {
            Value = value;
            Parent = parent;
        }

        public uint GetDepth()
        {
            BinaryTreeNode<T> currentNode = this;
            uint depth = 0;
            while (currentNode.Parent != null)
            {
                depth++;
                currentNode = currentNode.Parent;
            }
            return depth;
        }
    }
}
