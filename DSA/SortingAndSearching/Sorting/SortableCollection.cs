namespace SortingHomework
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;
        private RandomGenerator randomGenerator = RandomGenerator.GetInstance();

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            var result = false;

            foreach (var element in this.Items)
            {
                if (item.CompareTo(element) == 0)
                {
                    result = true;
                }
            }

            return result;
        }

        public bool BinarySearch(T item)
        {
            this.Sort(new SelectionSorter<T>());

            return this.BinarySearchRecursive(item, 0, this.items.Count);

        }

        private bool BinarySearchRecursive(T item, int minIndex, int maxIndex)
        {
            if (maxIndex <= minIndex)
            {
                return false;
            }

            // not to overflow if collection has many elements
            int middleIndex = minIndex + ((maxIndex - minIndex) / 2);

            if (this.Items[middleIndex].CompareTo(item) > 0)
            {
                return BinarySearchRecursive(item, minIndex, middleIndex - 1);
            }
            else if (this.Items[middleIndex].CompareTo(item) < 0)
            {
                return BinarySearchRecursive(item, middleIndex + 1, maxIndex);
            }
            else
            {
                return true;
            }
        }

        public void Shuffle()
        {
            var collectionLenght = this.items.Count;
            for (var i = 0; i < collectionLenght; i++)
            {
                // Exchange items[i] with random element in items[i..n-1]
                int r = i + this.randomGenerator.GetRandomInt(0, collectionLenght - i);
                var temp = this.items[i];
                this.items[i] = this.items[r];
                this.items[r] = temp;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
