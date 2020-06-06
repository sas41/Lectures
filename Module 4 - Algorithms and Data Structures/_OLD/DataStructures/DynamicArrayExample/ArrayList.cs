using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayExample
{
    class ArrayList<T>
    {
        const int InitialSize = 2;

        private T[] items;

        public int Count{ get; private set; }

        public ArrayList()
        {
            items = new T[InitialSize];
            Count = 0;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }

                return items[index];
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }

                items[index] = value;
            }
        }
        public T Get(int index)
        {
            return this[index];
        }

        public void Set(int index, T item)
        {
            this[index] = item;
        }

        public void Add(T item)
        {
            if (Count == items.Length)
            {
                Resize();
            }

            items[Count] = item;
            Count++;
        }

        private void Resize()
        {
            T[] newItems = new T[items.Length * 2];

            for (int i = 0; i < Count; i++)
            {
                newItems[i] = items[i];
            }

            items = newItems;
        }

        public T RemoveAt(int index)
        {
            T removed = items[index];

            Shift(index);

            items[Count - 1] = default(T);
            Count--;

            if (Count <= items.Length / 4)
            {
                Shrink();
            }

            return removed;
        }

        private void Shift(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }
        }

        private void Shrink()
        {
            T[] newItems = new T[items.Length / 2];

            for (int i = 0; i < Count; i++)
            {
                newItems[i] = items[i];
            }

            items = newItems;
        }
    }
}
