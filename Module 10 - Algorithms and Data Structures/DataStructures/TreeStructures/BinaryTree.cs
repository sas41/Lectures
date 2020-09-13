using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructures
{
    class BinaryTree<T> where T : IComparable<T>
    {
        public BinaryTreeNode<T> Root { get; set; }

        public BinaryTree(T firstValue)
        {
            Root = new BinaryTreeNode<T>(firstValue, null);
        }

        public BinaryTreeNode<T> Add(T value)
        {
            return AddRecursive(value, Root, 0);
        }

        private BinaryTreeNode<T> AddRecursive(T value, BinaryTreeNode<T> current, uint rank)
        {
            bool equal = value.CompareTo(current.Value) == 0;
            bool larger = value.CompareTo(current.Value) == 1;

            if (equal)
            {
                throw new ArgumentException("Value already exists in BinaryTree.");
            }
            else
            {
                if (larger)
                {
                    if (current.Right == null)
                    {
                        current.Right = new BinaryTreeNode<T>(value, current, rank+1);
                        return current.Right;
                    }
                    else
                    {
                        return AddRecursive(value, current.Right, current.InitialRank + 1);
                    }
                }
                else
                {
                    if (current.Left == null)
                    {
                        current.Left = new BinaryTreeNode<T>(value, current, rank+1);
                        return current.Left;
                    }
                    else
                    {
                        return AddRecursive(value, current.Left, current.InitialRank + 1);
                    }
                }
            }

        }


        public void AddManual(T addTo, T value, bool isLeft = true )
        {
            var node = FindNodeByValue(addTo, Root);
            if (node != null)
            {
                if (isLeft)
                {
                    node.Left = new BinaryTreeNode<T>(value, node);
                }
                else
                {

                    node.Right = new BinaryTreeNode<T>(value, node);
                }
            }
            else
            {
                throw new ArgumentException("Target Value/Node does not exist in the current BinaryTree.");
            }
        }

        public BinaryTreeNode<T> FindNodeByValue(T value, BinaryTreeNode<T> current)
        {
            if (current == null)
            {
                return null;
            }
            else if (current.Value.Equals(value))
            {
                return current;
            }
            else
            {
                var node = FindNodeByValue(value, current.Left);
                return node != null ? node : FindNodeByValue(value, current.Right);
            }
        }

    }
}
