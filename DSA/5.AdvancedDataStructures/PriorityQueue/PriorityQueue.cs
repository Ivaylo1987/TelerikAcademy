namespace PriorityQueue
{
    using System;
    using System.Collections.Generic;

    public class PriorityQueue<T>
    {
        private T[] items;
        private int heapSize;
        private Comparison<T> comparisonType;

        public PriorityQueue()
            : this(4, null)
        {
        }

        public PriorityQueue(Comparison<T> comparison)
            : this(4, comparison)
        {
        }

        public PriorityQueue(int capacity)
            : this(capacity, null)
        {
        }

        public PriorityQueue(int capacity, Comparison<T> comparison)
        {
            this.items = new T[capacity];
            this.comparisonType = comparison;

            if (comparison == null)
            {
                this.comparisonType = new Comparison<T>(Comparer<T>.Default.Compare);
            }
        }

        public int Count
        {
            get
            {
                return this.heapSize;
            }

            set
            {
                this.heapSize = value;
            }
        }

        public void Enqueue(T item)
        {
            if (this.Count == this.items.Length)
            {
                this.ResizeHeap();
            }

            this.items[this.Count] = item;
            this.HeapUp(this.Count);
            this.Count++;
        }

        public T Peak()
        {
            return this.items[0];
        }

        public T Dequeue()
        {
            T item = this.items[0];
            this.Count--;

            this.items[0] = this.items[this.Count];
            this.HeapDown(0);

            return item;
        }

        private void ResizeHeap()
        {
            T[] resizedData = new T[this.items.Length * 2];
            Array.Copy(this.items, 0, resizedData, 0, this.items.Length);
            this.items = resizedData;
        }

        private void HeapUp(int childIndex)
        {
            if (childIndex > 0)
            {
                int parentIndex = (childIndex - 1) / 2;

                if (this.IsFirstGreaterThanSecond(childIndex, parentIndex))
                {
                    this.SwapItems(parentIndex, childIndex);
                    this.HeapUp(parentIndex);
                }
            }
        }

        private void HeapDown(int parentIndex)
        {
            int leftChildIndex = (2 * parentIndex) + 1;
            int rightChildIndex = leftChildIndex + 1;
            int largestChildIndex = parentIndex;

            if (leftChildIndex < this.Count && this.IsFirstGreaterThanSecond(leftChildIndex, largestChildIndex))
            {
                largestChildIndex = leftChildIndex;
            }

            if (rightChildIndex < this.Count && this.IsFirstGreaterThanSecond(rightChildIndex, largestChildIndex))
            {
                largestChildIndex = rightChildIndex;
            }

            if (largestChildIndex != parentIndex)
            {
                this.SwapItems(parentIndex, largestChildIndex);
                this.HeapDown(largestChildIndex);
            }
        }

        private void SwapItems(int parentIndex, int childIndex)
        {
            T tempItem = this.items[parentIndex];
            this.items[parentIndex] = this.items[childIndex];
            this.items[childIndex] = tempItem;
        }

        private bool IsFirstGreaterThanSecond(int indexA, int indexB)
        {
            if (this.comparisonType.Invoke(this.items[indexA], this.items[indexB]) > 0)
            {
                return true;
            }

            return false;
        }
    }
}