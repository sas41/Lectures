using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsSkeleton
{
    class Deque<T>
    {
        private List<T> ts;
        private Stack<T> history;

        public int Count
        {
            get { return ts.Count; }
        }

        public Deque()
        {
            ts = new List<T>();
            history = new Stack<T>();
        }

        public void AddFront(T item)
        {
            ts.Add(item);
        }

        public void AddBack(T item)
        {
            ts.Insert(0,item);
        }

        public T RemoveFront()
        {
            T ret = ts[ts.Count - 1];
            ts.RemoveAt(ts.Count - 1);
            history.Push(ret);
            return ret;
        }

        public T RemoveBack()
        {
            T ret = ts[0];
            ts.RemoveAt(0);
            history.Push(ret);
            return ret;
        }

        public T GetFront()
        {
            return ts[ts.Count - 1];
        }

        public T GetBack()
        {
            return ts[0];
        }

        public List<T> GetHistory()
        {
            return history.ToList();
        }
    }
}
