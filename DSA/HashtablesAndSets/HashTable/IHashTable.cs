﻿namespace HashTable
{
    using System;
    using System.Collections.Generic;

    public class IHashTable<TKey, TValue>
        where TKey : IEquatable<TKey>
    {
        private const int InitialSize = 16;
        private List<KeyValuePair<TKey, TValue>>[] elements;
        private int count;

        public IHashTable()
            : this(InitialSize)
        {
        }

        public IHashTable(int size)
        {
            this.elements = new List<KeyValuePair<TKey, TValue>>[size];
            this.count = 0;
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        private void Resize()
        {
            var newElements = new List<KeyValuePair<TKey, TValue>>[elements.Length * 2];

            for (int i = 0; i < elements.Length; i++)
            {
                newElements[i] = elements[i];
            }

            this.elements = newElements;
        }

        public void Clear()
        {
            this.elements = new List<KeyValuePair<TKey, TValue>>[InitialSize];
        }

        public TValue this[TKey index]
        {
            get
            {
                var hash = this.IGetHashCode(index);

                if (!this.IsHasPresent(hash))
                {
                    throw new KeyNotFoundException("This element is not present");
                }

                return FindElement(hash, index).Value;
            }
            set
            {
                var hash = this.IGetHashCode(index);

                if (!this.IsHasPresent(hash))
                {
                    this.Add(index, value);
                }
                else
                {
                    var pair = this.FindElement(hash, index);
                    pair = new KeyValuePair<TKey, TValue>(index, value);
                }
            }
        }

        private bool ShouldHashTableResize()
        {
            var result = false;

            if (this.count > this.elements.Length * 0.75)
            {
                result = true;
            }

            return result;
        }

        public void Add(TKey key, TValue value)
        {
            var hash = IGetHashCode(key);

            if (this.elements[hash] == null)
            {
                this.elements[hash] = new List<KeyValuePair<TKey, TValue>>();
            }

            var pair = new KeyValuePair<TKey, TValue>(key, value);
            this.elements[hash].Add(pair);
        }

        public TValue Find(TKey key)
        {
            var hash = this.IGetHashCode(key);
            var result = this.FindElement(hash, key).Value;

            return result;
        }

        private KeyValuePair<TKey, TValue> FindElement(int hash, TKey key)
        {
            var result = new KeyValuePair<TKey, TValue>();
            foreach (var pair in this.elements[hash])
            {
                if (pair.Key.Equals(key))
                {
                    result = pair;
                }
            }

            return result;
        }

        private bool IsHasPresent(int hash)
        {
            var result = true;

            if (this.elements[hash] == null)
            {
                result = false;
            }

            return result;
        }

        private int IGetHashCode(TKey key)
        {
            var hash = key.GetHashCode();
            hash = Math.Abs(hash) % this.elements.Length;

            return hash;
        }
    }
}