using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
    public class Node<T>
    {
        public Node<T> Head;
        public Node<T> Tail;

        public T Value { get; set; }

        public Node(T initial = default(T))
        {
            Value = initial;
            Head = null;
            Tail = null;
        }
    }
}
