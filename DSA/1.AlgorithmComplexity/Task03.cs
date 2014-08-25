// * What is the expected running time of the following C# code? Explain why.
// Assume the input matrix has size of n * m.

long CalcSum(int[, ] matrix, int row)
{
	long sum = 0;

	for (int col = 0; col < matrix.GetLength(0); col++)
	{
		sum += matrix[row, col];
	}

	if (row + 1 < matrix.GetLength(1))
	{
		sum += CalcSum(matrix, row + 1);
	}

	return sum;
}

Console.WriteLine(CalcSum(matrix, 0));

// Explanation
// The loop goes N times and the recursive call can happen worst case m times therefore 
// The complexity should be O(n to the power of  m) (n на степен m)
