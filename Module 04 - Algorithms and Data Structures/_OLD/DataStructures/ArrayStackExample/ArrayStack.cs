using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStackExample
{
    class ArrayStack<T>
    {
        private const int initialSize = 8;
        private T[] elements;
        private int index;

        public int Count { get; private set; }

        public ArrayStack()
        {
            elements = new T[initialSize];
            index = 0;
        }

        public void Push(T element)
        {
            if (index >= elements.Length)
            {
                Grow();
            }
            elements[index] = element;
            index++;
            Count++;
        }

        public T Pop()
        {
            if (Count > 0)
            {
                index--;
                T element = elements[index];
                elements[index] = default(T);
                Count--;

                if (Count <= elements.Length / 4)
                {
                    Shrink();
                }
                return element;
            }
            else
            {
                throw new Exception("Stack is Empty!");
            }
        }

        public T Peek()
        {
            if (Count > 0)
            {
                return elements[index - 1];
            }
            else
            {
                throw new Exception("Stack is Empty!");
            }
        }

        private void Grow()
        {
            T[] newElements = new T[elements.Length * 2];
            for (int i = 0; i < elements.Length; i++)
            {
                newElements[i] = elements[i];
            }
            elements = newElements;
        }

        private void Shrink()
        {
            T[] newElements = new T[elements.Length / 2];
            for (int i = 0; i < elements.Length; i++)
            {
                newElements[i] = elements[i];
            }
            elements = newElements;
        }
    }
}
