using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.StackT
{
    public class StackT<T>
    {
        private T[] storage;
        private int count;

        public int Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }

        public StackT()
        {
            this.storage = new T[1];
            this.Count = 0;
        }

        public void Push(T item)
        {
            if (this.Count == this.storage.Length)
            {
                ResizeStorage();
            }

            this.storage[this.Count] = item;
            this.Count++;
        }

        public T Pop()
        {
            T item = this.storage[this.Count - 1];
            this.Count--;
            return item;
        }

        public T Peek()
        {
            T item = this.storage[this.Count - 1];
            return item;
        }

        public void Clear()
        {
            this.storage = new T[1];
            this.Count = 0;
        }

        private void ResizeStorage()
        {
            T[] newStorage = new T[this.storage.Length * 2];
            for (int i = 0; i < this.storage.Length; i++)
            {
                newStorage[i] = this.storage[i];
            }

            this.storage = newStorage;
        }
    }
}
