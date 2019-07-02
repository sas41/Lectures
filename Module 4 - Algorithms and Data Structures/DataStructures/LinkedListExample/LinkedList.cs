using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
    class LinkedList<T>
    {
        Node<T> start;


        public LinkedList()
        {

        }

        public T this[int index]
        {
            get
            {
                return GetAt(index).Value;
            }
            set
            {
                GetAt(index).Value = value;
            }
        }

        private Node<T> GetLast()
        {
            Node<T> result = start.Head;
            if (result == null)
            {
                return start;
            }
            else
            {
                while (result.Head != null)
                {
                    result = result.Head;
                }
                return result;
            }
        }

        private Node<T> GetAt(int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            Node<T> current = start;
            for (int i = 0; i < index; i++)
            {
                if (current == null)
                {
                    throw new IndexOutOfRangeException();
                }
                current = current.Head;
            }
            return current;
        }

        public void Add(T item)
        {
            if (start == null)
            {
                start = new Node<T>(item);
            }
            else
            {
                Node<T> last = GetLast();
                last.Head = new Node<T>(item);
                Node<T> newNode = last.Head;
                newNode.Tail = last;
                
            }
        }

        public void RemoveAt(int index)
        {
            if (index == 0)
            {
                start = start.Head;
                start.Tail = null;
                return;
            }

            Node<T> current = GetAt(index);

            Node<T> prev, next;
            prev = current.Tail;
            next = current.Head;

            prev.Head = next;

            if (next != null)
            {
                next.Tail = prev;
            }
        }


        public int Count()
        {
            int count = 0;
            Node<T> current = start;
            while (current != null)
            {
                count++;
                current = current.Head;
            }

            return count;
        }
    }
}
