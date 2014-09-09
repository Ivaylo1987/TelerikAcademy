namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            this.QuickSort(collection, 0, collection.Count - 1);
        }

        private void QuickSort(IList<T> collection, int lowIndex, int highIndex)
        {
            if (highIndex <= lowIndex)
            {
                return;
            }

            int pivotIndex = Partition(collection, lowIndex, highIndex);
            QuickSort(collection, lowIndex, pivotIndex - 1);
            QuickSort(collection, pivotIndex + 1, highIndex);
        }

        private int Partition(IList<T> collection, int lowIndex, int highIndex)
        {
            int first = lowIndex;
            int last = highIndex + 1;
            T pivot = collection[lowIndex];
            while (true)
            {
                // find item on lowIndex to swap
                while (IsLess(collection[++first], pivot))
                {
                    if (first == highIndex)
                    {
                        break;
                    }
                }

                // find item on highIndex to swap
                while (IsLess(pivot, collection[--last]))
                {
                    if (last == lowIndex)
                    {
                        break; // redundant since collection[lowIndex] acts as sentinel
                    }
                }

                // check if pointers cross
                if (first >= last)
                {
                    break;
                }

                Swap(collection, first, last);
            }

            // put partitioning item pivot at collection[last]
            Swap(collection, lowIndex, last);

            // now, collection[lowIndex .. pivotIndex-1] <= collection[pivotIndex] <= collection[pivotIndex+1 .. highIndex]
            return last;
        }

        private bool IsLess(T v, T w)
        {
            return (v.CompareTo(w) < 0);
        }

        private void Swap(IList<T> collection, int i, int j)
        {
            T swap = collection[i];
            collection[i] = collection[j];
            collection[j] = swap;
        }
    }
}
