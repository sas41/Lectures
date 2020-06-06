using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueueExample
{
    class CircularQueue<T>
    {
        const int defaultCapacity = 4;
        private T[] elements;
        private int startIndex, endIndex;
        
        public int Count { get; private set; }

        public CircularQueue()
        {
            elements = new T[defaultCapacity];
            startIndex = 0;
            endIndex = 0;
            Count = 0;
        }

        public void Enqueue(T element)
        {
            if (Count == elements.Length)
            {
                Grow();
            }

            elements[endIndex] = element;
            Count++;
            endIndex++;
            if (endIndex >= elements.Length)
            {
                endIndex = 0;
            }
        }

        public T Dequeue()
        {
            T item = elements[startIndex];

            if (Count > 0)
            {
                elements[startIndex] = default(T);
                Count--;
                startIndex++;
                if (startIndex >= elements.Length)
                {
                    startIndex = 0;
                }

                if (Count <= elements.Length / 4 )
                {
                    Shrink();
                }

            }
            else
            {
                throw new Exception("CircularQueue is Empty!");
            }

            return item;
        }

        public T Peek()
        {
            return elements[startIndex];
        }

        private void Grow()
        {
            T[] newElements = new T[elements.Length * 2];

            int index = 0;
            int oldCount = Count;
            while (Count > 0)
            {
                newElements[index] = Dequeue();
                index++;
            }
            Count = oldCount;
            startIndex = 0;
            endIndex = index;
            elements = newElements;

        }

        private void Shrink()
        {
            T[] newElements = new T[elements.Length / 2];

            int index = 0;
            int oldCount = Count;
            while (Count > 0)
            {
                newElements[index] = Dequeue();
                index++;
            }
            Count = oldCount;
            startIndex = 0;
            endIndex = index;
            elements = newElements;
        }

        public T[] ToArray()
        {
            T[] result = new T[Count];
            int index = startIndex;
            for (int i = 0; i < Count; i++)
            {
                result[i] = elements[index];
                index++;
                if (index >= elements.Length)
                {
                    index = 0;
                }
            }

            return result;
        }
    }
}
