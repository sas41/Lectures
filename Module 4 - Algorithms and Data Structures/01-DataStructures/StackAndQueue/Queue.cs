using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace StackAndQueue
{
    class Queue<T>
    {
        private Node<T> Head { get; set; }
        private Node<T> Tail { get; set; }
        public int Count { get; set; }

        public void Enqueue(T item)
        {
            if (Head == null)
            {
                Head = new Node<T>(item);
                Tail = Head;
            }
            else
            {
                Tail.Next = new Node<T>(item);
                Tail = Tail.Next;
            }
            Count++;
        }

        public T Dequeue()
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
            Tail = null;
        }
    }
}
