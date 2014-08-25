// What is the expected running time of the following C# code? Explain why.
// Assume the input matrix has size of n * m.

long CalcCount(int[, ] matrix)
{
	long count = 0;
	for (int row = 0; row < matrix.GetLength(0); row++)
	{
		if (matrix[row, 0] % 2 == 0)
		{
			for (int col = 0; col < matrix.GetLength(1); col++)
			{
				if (matrix[row, col] > 0)
				{
					count++;
				}
			}
		}
	}

	return count;
}

// Explanation
// First loop goes N times. Second loop goes m times but only when we have an even element the worst case complexity
// Should be O(n * m)