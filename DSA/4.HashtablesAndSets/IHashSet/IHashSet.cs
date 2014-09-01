namespace IHashSet
{
    using HashTable;
    using System.Collections;
    using System.Collections.Generic;

    public class IHashSet<T> : IEnumerable<T>
    {
        private IHashTable<int, T> hashTable;

        public IHashSet()
        {
            this.hashTable = new IHashTable<int, T>();
        }

        public int Count { get { return this.hashTable.Count; } }

        public void Add(T value)
        {
            this.hashTable.Add(value.GetHashCode(), value);
        }

        public void Remove(T value)
        {
            this.hashTable.Remove(value.GetHashCode());
        }

        public void Find(T value)
        {
            this.hashTable.Find(value.GetHashCode());
        }

        public void Clear()
        {
            this.hashTable.Clear();
        }

        public IHashSet<T> Intersect(IHashSet<T> set)
        {
            var result = new IHashSet<T>();

            foreach (var element in this)
            {
                foreach (var value in set)
                {
                    if (element.Equals(value))
                    {
                        result.Add(value);
                    }
                }
            }

            return result;
        }

        public IHashSet<T> Union(IHashSet<T> set)
        {
            var result = new IHashSet<T>();

            foreach (var element in this)
            {
                result.Add(element);
            }

            foreach (var item in set)
            {
                result.Add(item);
            }

            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var element in this.hashTable)
            {
                yield return element.Value;
            }
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
