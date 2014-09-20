using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequences
{

    class Program
    {
        private static List<string> result = new List<string>();

        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var sequence = new string[count];

            for (int i = 0; i < count; i++)
            {
                sequence[i] = (Console.ReadLine());
            }

            Perm<string>(sequence, 0);

            var bestCount = int.MaxValue;
            int final = 0;

            foreach (var item in result)
            {
                var currentInt = int.Parse(item);
                var current = GetDivisors(int.Parse(item));

                if (current < bestCount)
                {
                    final = currentInt;
                    bestCount = current;
                }
                else if(current == bestCount)
                {
                    final = Math.Min(final, currentInt);
                }
                
            }

            Console.WriteLine(final);
        }

        static void Perm<T>(T[] arr, int k)
        {
            if (k >= arr.Length)
            {
                ReturnPermutation(arr);
            }
            else
            {
                Perm(arr, k + 1);
                for (int i = k + 1; i < arr.Length; i++)
                {
                    Swap(ref arr[k], ref arr[i]);
                    Perm(arr, k + 1);
                    Swap(ref arr[k], ref arr[i]);
                }
            }
        }

        private static void Swap<T>(ref T first, ref T second)
        {
            var temp = first;
            first = second;
            second = temp;
        }

        static void ReturnPermutation<T>(T[] arr)
        {
            result.Add(string.Join("", arr));
        }

        static int GetDivisors(int n)
        {
            var devisors = from a in Enumerable.Range(2, n / 2)
            where n % a == 0
            select a;

            return devisors.Count();
        }
    }
}
