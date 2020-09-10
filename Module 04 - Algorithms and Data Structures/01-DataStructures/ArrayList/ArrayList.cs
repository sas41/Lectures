using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample
{
    class ArrayList<T>
    {
        const int initialSize = 2;
        private T[] items;
        public int Count { get; private set; }

        public ArrayList()
        {
            items = new T[initialSize];
            Count = 0;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException("The index was out of bounds of the internal array!");
                }
                return items[index];
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException("The index was out of bounds of the internal array!");
                }
                items[index] = value;
            }
        }

        public void Add(T item)
        {
            if (items.Length == Count)
            {
                Expand();
            }

            items[Count] = item;
            Count++;
        }

        public T Get(int index)
        {
            return items[index];
        }

        public T RemoveAt(int index)
        {
            T removed = items[index];

            for (int i = index; i < Count-1; i++)
            {
                items[i] = items[i + 1];
            }

            items[Count-1] = default(T);
            Count--;

            if (Count <= items.Length / 4)
            {
                Shrink();
            }

            return removed;
        }

        public void Set(int index, T item)
        {
            items[index] = item;
        }

        private void Expand()
        {
            T[] expanded = new T[items.Length * 2];
            
            for (int i = 0; i < items.Length; i++)
            {
                expanded[i] = items[i];
            }

            items = expanded;

            //variable	address		value
            //items[]		0x0000F	=>	{5, 6, 12, 99}
            //expanded[]	0x00A9E	=>	{5, 6, 12, 99, X, X, X, X}

            //items	= expanded
            //0x0000F	= 0x00A9E
            //items	-> 0x00A9E

            //variable	address		value
            //items[]		0x00A9E	=>	{5, 6, 12, 99, X, X, X, X}
            //expanded[]	0x00A9E	=>	{5, 6, 12, 99, X, X, X, X}
        }

        private void Shrink()
        {
            T[] shrunk = new T[items.Length / 2];

            for (int i = 0; i < Count; i++)
            {
                shrunk[i] = items[i];
            }

            items = shrunk;

        }
    }
}
