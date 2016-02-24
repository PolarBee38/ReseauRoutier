using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace road_network
{
    
    
    public class priorityQueue<T>
    {
        private class priorityComp<T> : IComparer<coupleItem<T, double>>
        {
            public int Compare(coupleItem<T, double> x, coupleItem<T, double> y)
            {
                return x.getValue().CompareTo(y.getValue());
            }
        }
        List<coupleItem<T,double>> queue;
        priorityComp<T> pc;
        public priorityQueue()
        {
            queue = new List<coupleItem<T,double>>();
            pc = new priorityComp<T>();
        }
        public bool isEmpty()
        {
            return queue.Count <= 0;
        }
        public void enqueue(T item, double priority)
        {
            enqueue(new coupleItem<T,double>(item, priority));
        }
        public void enqueue(coupleItem<T,double> item)
        {
            int index = queue.BinarySearch(item, pc);
            if (index < 0)
                queue.Insert(~index, item);
            else
                queue.Insert(index, item);

        }
        public T dequeue()
        {
            double a;
            return dequeue(out a);
        }
        public T dequeue(out double priority)
        {
            priority = 0;
            if (queue.Count >= 1)
            {
                T item = queue[0].getItem();
                priority = queue[0].getValue();
                queue.RemoveAt(0);
                return item;
            }
            return default(T);
        }
        public List<coupleItem<T, double>> getList()
        {
            return queue;
        }
      
        public int Count
        {
            get
            {
                return queue.Count;
            }
        }
    }
}
