using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace road_network
{
    public class coupleItem<T,K>
    {
        T key;
        K value;
        public coupleItem()
        {
            key = default(T);
            value = default(K);
        }
        public coupleItem(T k)
        {
            key = k;
            value = default(K);
        }
        public coupleItem(T k, K v)
        {
            key = k;
            value = v;
        }
        public K getValue()
        {
            return value;
        }
        public T getItem()
        {
            return key;
        }
    }
}
