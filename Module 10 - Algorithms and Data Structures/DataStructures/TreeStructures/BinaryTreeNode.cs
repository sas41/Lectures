using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructures
{
    class BinaryTreeNode<T> where T : IComparable<T>
    {

        public BinaryTreeNode<T> Parent { get; set; }

        public T Value { get; set; }

        public uint InitialRank { get; set; }

        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode(T value, BinaryTreeNode<T> parent, uint rank = 0)
        {
            Value = value;
            Parent = parent;
            InitialRank = rank;
        }
    }
}
