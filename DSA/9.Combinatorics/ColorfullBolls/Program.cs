namespace ColorfullBolls
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        private static int count = 0;
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var charArr = input.ToArray();
            Array.Sort(charArr);

            PermuteRep(charArr, 0, charArr.Length);
            Console.WriteLine(count);

        }

        static void PermuteRep(char[] arr, int start, int n)
        {
            count++;
            for (int left = n - 2; left >= start; left--)
            {
                for (int right = left + 1; right < n; right++)
                    if (arr[left] != arr[right])
                    {
                        Swap(ref arr[left], ref arr[right]);
                        PermuteRep(arr, left + 1, n);
                    }
                var firstElement = arr[left];
                for (int i = left; i < n - 1; i++)
                    arr[i] = arr[i + 1];
                arr[n - 1] = firstElement;
            }
        }

        private static void Swap<T>(ref T first, ref T second)
        {
            var temp = first;
            first = second;
            second = temp;
        }
    }
}
