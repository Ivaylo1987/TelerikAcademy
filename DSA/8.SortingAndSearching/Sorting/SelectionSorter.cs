namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            var minIndex = 0;

            for (int i = 0; i < collection.Count - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (collection[minIndex].CompareTo(collection[j]) >= 0)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    var temp = collection[minIndex];
                    collection[minIndex] = collection[i];
                    collection[i] = temp;
                }
            }
        }
    }
}
