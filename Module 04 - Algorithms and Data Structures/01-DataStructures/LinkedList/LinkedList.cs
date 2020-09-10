using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
    class Node<T>
    {
        public T Item { get; set; }
        public Node<T> Next { get; set; }
    }

    class LinkedList<T>
    {
        private Node<T> Head;
        private Node<T> Tail;
        public int Count { get; private set; }

        public T this[int index]
        { 
            get
            {
                return this.Get(index);
            }
            set
            {
                Set(index, value);
            }
        }

        public void Add(T item)
        {
            if (Head is null)
            {
                Head = new Node<T>();
                Head.Item = item;
                Tail = Head;
            }
            else
            {
                Node<T> newNode = new Node<T>();
                newNode.Item = item;
                Tail.Next = newNode;

                Tail = Tail.Next;
                //Tail = newNode;
            }

            Count++;
        }

        public T RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            T toRemove;

            if (index == 0)
            {
                toRemove = Head.Item;
                Head = Head.Next;
            }
            else
            {
                Node<T> current = Head;
                Node<T> last = null;

                for (int i = 0; i < index; i++)
                {
                    last = current;
                    current = current.Next;
                }

                toRemove = current.Item;
                last.Next = current.Next;

                if (last.Next == null)
                {
                    Tail = last;
                }
            }

            Count--;
            return toRemove;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            Node<T> current = Head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current.Item;
        }

        public void Set(int index, T item)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            Node<T> current = Head;

            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            current.Item = item;
        }

        public bool Remove(T item)
        {
            Node<T> current = Head;
            Node<T> last = null;

            if (Head.Item.Equals(item))
            {
                Head = Head.Next;
                Count--;
                return true;
            }
            else
            {
                while (!(current is null))
                {
                    if (current.Item.Equals(item))
                    {
                        last.Next = current.Next;
                        Count--;
                        return true;
                    }
                    last = current;
                    current = current.Next;
                }
            }
            return false;
        }
    }
}
