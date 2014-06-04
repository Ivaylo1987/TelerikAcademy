namespace AssertionsHomework
{
    using System;
    public class Demo
    {
        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            AssertionsHomework.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));


            var emptyArr = new int[0];
            AssertionsHomework.SelectionSort(emptyArr); // Test sorting empty array
            Console.WriteLine(string.Join(", ", emptyArr)); //prints nothing as Array.Sort()

            var singleElementArr = new int[1];
            AssertionsHomework.SelectionSort(singleElementArr); // Test sorting single element array
            Console.WriteLine(string.Join(", ", singleElementArr)); // returns 0

            Console.WriteLine(AssertionsHomework.BinarySearch(arr, -1000));
            Console.WriteLine(AssertionsHomework.BinarySearch(arr, 0));
            Console.WriteLine(AssertionsHomework.BinarySearch(arr, 17));
            Console.WriteLine(AssertionsHomework.BinarySearch(arr, 10));
            Console.WriteLine(AssertionsHomework.BinarySearch(arr, 1000));
        }
    }
}
