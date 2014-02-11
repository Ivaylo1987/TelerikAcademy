namespace Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Extensions
    {
        // Extension method Substring on StringBuilder type.
        public static string SubString(this StringBuilder strBuilder, int index, int length)
        {
            StringBuilder result = new StringBuilder();

            if (index + length >= strBuilder.Length)
            {
                throw new IndexOutOfRangeException("Index out of range! Not enough cahracters in string!");
            }
            else
            {
                for (int i = index; i < index + length; i++)
                {
                    result.Append(strBuilder[i]);
                }
            }

            return result.ToString();
        }

        // Extension method Sum to IEnumerable<T>
        public static T SumExt<T>(this IEnumerable<T> collection)
        {
            dynamic result = 0;
            foreach (var item in collection)
            {
                result += item;
            }

            return result;
        }

        // Extension method Product to IEnumerable<T>
        public static dynamic Product<T>(this IEnumerable<T> collection)
        {
            dynamic result = 1;
                    
            foreach (var item in collection)
            {
                result *= item;
            }

            return result;
        }

        // Extension method Average to IEnumerable<T>
        public static T AverageExt<T>(this IEnumerable<T> collection)
        {
            dynamic result = 0;
            dynamic count = 0;
            foreach (var item in collection)
            {
                result += item;
                count++;
            }

            return result / count;
        }

        // Extension method Min to IEnumerable<T>
        public static T MinExt<T>(this IEnumerable<T> collection)
            where T: IComparable
        {
            T minElement = collection.FirstOrDefault();

            if (minElement != null)
            {
                foreach (var item in collection)
                {
                    if (item.CompareTo(minElement) < 0)
                    {
                        minElement = item;
                    }
                }
            }
            else
            {
                throw new NullReferenceException("Null reference occured!");
            }

            return minElement;
        }

        // Extension method Мax to IEnumerable<T>
        public static T MaxExt<T>(this IEnumerable<T> collection)
            where T : IComparable
        {
            T maxElement = collection.FirstOrDefault();

            if (maxElement != null)
            {
                foreach (var item in collection)
                {
                    if (item.CompareTo(maxElement) > 0)
                    {
                        maxElement = item;
                    }
                }
            }
            else
            {
                throw new NullReferenceException("Null reference occured!");
            }

            return maxElement;
        }
    }
}
