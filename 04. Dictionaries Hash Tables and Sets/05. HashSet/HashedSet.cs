namespace _05.HashSet
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using _04.HashTable;

    public class HashedSet<T> : IEnumerable<T>
    {
        private HashTable<T, T> container;

        public HashedSet(params T[] values)
        {
            this.container = new HashTable<T, T>();

            if (values != null)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    this.container.Add(values[i], values[i]);
                }
            }
        }

        public int Count
        {
            get { return this.container.Count; }
            private set { }
        }

        public void Add(T value)
        {
            this.container.Add(value, value);
        }

        public void Remove(T value)
        {
            this.container.Remove(value);
        }

        public T Find(T value)
        {
            T lookedValue = this.container.Find(value);

            return lookedValue;
        }

        public void Clear()
        {
            this.container = new HashTable<T, T>();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.container)
            {
                yield return item.Value;
            }
        }

        public void Union(HashedSet<T> otherSet)
        {
            foreach (var item in otherSet)
            {
                this.container.Add(item, item);
            }
        }

        public void IntersectWith(HashedSet<T> otherSet)
        {
            HashTable<T, T> otherTable = new HashTable<T, T>();
            foreach (var item in otherSet)
            {
                if (this.container.Contains(new KeyValuePair<T, T>()))
                {
                    otherTable.Add(item, item);
                }
            }

            this.container = otherTable;
        }
    }
}