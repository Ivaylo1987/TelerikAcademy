namespace DefiningClassesII
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GenericList<T>
    {
        // Fields
        private T[] list;

        // Constructors
        public GenericList()
        {
            this.Capacity = 4;
            this.list = new T[this.Capacity];
            this.Count = 0;
        }

        public GenericList(int sizeOfList)
            : this()
        {
            this.Capacity = sizeOfList;
            this.list = new T[this.Capacity];
        }

        // Properties
        public int Capacity { get; private set; }

        public int Count { get; private set; }

        // Methods
        // Indexer
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < this.Count)
                {
                    return this.list[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid index value!");
                }
            }

            set
            {
                if (index >= 0 && index < this.Count)
                {
                    this.list[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid index value!");
                }
            }
        }

        // Add item
        public void Add(T item)
        {
            // If count is equal to capacity make Capacity twice as big.
            if (this.Count == this.Capacity)
            {
                this.Expand();
            }

            this.list[this.Count] = item;
            this.Count++;
        }

        // Insert itam at position
        public void InsertAt(int index, T element)
        {
            if (index == this.Count && this.Count == this.Capacity)
            {
                this.Expand();
            }

            T[] tempList = new T[this.Capacity];
            int indexOfNewArray = 0;

            for (int i = 0; i < this.Count; i++)
            {
                if (i == index)
                {
                    tempList[indexOfNewArray++] = element;
                }

                tempList[indexOfNewArray++] = this.list[i];
            }

            this.list = tempList;
            this.Count++;
        }

        // Remove item at position
        public void RemoveAt(int index)
        {
            T[] tempList = new T[this.Capacity];
            int indexOfNewArray = 0;

            for (int i = 0; i < this.Count; i++)
            {
                if (i == index)
                {
                    continue;
                }

                tempList[indexOfNewArray++] = this.list[i];
            }

            this.list = tempList;
            this.Count--;
        }

        // Finding element - return -1 if they isn't an equal element.
        public int FindItem(T item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (list[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        // Find min element
        public T Min<T>()
            where T : IComparable
        {
            dynamic result = this.list.Min();
            return result;
        }

        // Find Max Value
        public T Max<T>()
            where T : IComparable
        {
            dynamic result = this.list.Max();
            return result;
        }

        // Clear All
        public void Clear()
        {
            this.list = new T[this.Capacity];
        }

        // Expand the size of the list
        private void Expand()
        {
            int newSize = this.Capacity * 2;
            T[] tempList = new T[newSize];

            for (int i = 0; i < this.Capacity; i++)
            {
                tempList[i] = this.list[i];
            }

            this.Capacity = newSize;
            this.list = tempList;
        }

        public override string ToString()
        {
            return string.Join(" ", this.list);
        }
    }
}
