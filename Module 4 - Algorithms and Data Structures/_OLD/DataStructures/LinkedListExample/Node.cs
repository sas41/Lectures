using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
    public class Node<T>
    {
        public Node<T> Previous;
        public Node<T> Next;

        public T Value { get; set; }

        public Node(T initial = default(T))
        {
            Value = initial;
            Previous = null;
            Next = null;
        }
    }
}
