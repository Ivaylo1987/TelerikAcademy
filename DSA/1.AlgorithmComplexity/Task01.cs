// What is the expected running time of the following C# code? Explain why. Assume the array's size is n.

long Compute(int[] arr)
{
	long count = 0;
	for (int i = 0; i < arr.Length; i++)
	{
		int start = 0;
		int end = arr.Length - 1;
		while (start < end)
		{
			if (arr[start] < arr[end])
			{
				start++;
				count++;
			}
			else
			{
				end--;
			}
		}
	}

	return count;
}

// Explanation
// We have two nested loops. Both running N times (the array size) therefore complexity should be O(n * n)