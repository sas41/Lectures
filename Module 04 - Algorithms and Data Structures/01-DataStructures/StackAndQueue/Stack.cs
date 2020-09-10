using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class Stack<T>
    {
        // Node -> Next.Node
        // Previous.Node <- Node
        Node<T> Head { get; set; }
        public int Count { get; set; }

        public void Push(T item)
        {
            Node<T> newNode = new Node<T>(item);
            newNode.Next = Head;
            Head = newNode;
            Count++;
        }

        public T Pop()
        {
            if (Head != null)
            {
                T item = Head.Item;
                Head = Head.Next;
                Count--;
                return item;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public T Peek()
        {
            if (Head != null)
            {
                return Head.Item;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public bool Contains(T item)
        {
            Node<T> current = Head;
            while (current != null)
            {
                if (current.Item.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public T[] ToArray()
        {
            T[] array = new T[Count];

            Node<T> current = Head;

            for (int i = 0; i < Count; i++)
            {
                array[i] = current.Item;
                current = current.Next;
            }
            return array;
        }

        public void Clear()
        {
            Head = null;
        }
    }
}
