using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.LinkedQueue
{
    public class LinkedQueue<T>
    {
        private LinkedList<T> list;

        public LinkedQueue()
        {
            this.list = new LinkedList<T>();
        }

        public void Enqueue(T item)
        {
            this.list.AddLast(item);
        }

        public T Peek()
        {
            if (this.list.Count == 0)
            {
                throw new ArgumentException("The queue is empty!");
            }
            return this.list.First.Value;
        }

        public T Dequeue()
        {
            T itemToGet = this.Peek();
            this.list.RemoveFirst();
            return itemToGet;
        }

        public int Count { get { return this.list.Count; } }
    }
}
