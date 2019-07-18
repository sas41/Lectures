using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
    class LinkedList<T>
    {
        Node<T> head;


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
            Node<T> result = head.Previous;
            if (result == null)
            {
                return head;
            }
            else
            {
                while (result.Previous != null)
                {
                    result = result.Previous;
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

            Node<T> current = head;
            for (int i = 0; i < index; i++)
            {
                if (current == null)
                {
                    throw new IndexOutOfRangeException();
                }
                current = current.Previous;
            }
            return current;
        }

        public void Add(T item)
        {
            if (head == null)
            {
                head = new Node<T>(item);
            }
            else
            {
                Node<T> last = GetLast();
                last.Previous = new Node<T>(item);
                Node<T> newNode = last.Previous;
                newNode.Next = last;
                
            }
        }

        public void RemoveAt(int index)
        {
            if (index == 0)
            {
                head = head.Previous;
                head.Next = null;
                return;
            }

            Node<T> current = GetAt(index);

            Node<T> prev, next;
            prev = current.Next;
            next = current.Previous;

            prev.Previous = next;

            if (next != null)
            {
                next.Next = prev;
            }
        }


        public int Count()
        {
            int count = 0;
            Node<T> current = head;
            while (current != null)
            {
                count++;
                current = current.Previous;
            }

            return count;
        }
    }
}
