namespace DefiningClassesII
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Matrix<T>
        where T : struct
    {
        // Fields
        private T[,] matrix;
        

        // Constructor
        public Matrix(int firstDimentionSize, int secondDimentionSize)
        {
            matrix = new T[firstDimentionSize, secondDimentionSize];
        }

        // Indexer
        public T this[int firstIndex, int secondIndex]
        {
            get
            {
                if (firstIndex >= 0 && firstIndex < matrix.GetLength(0) &&
                    secondIndex >= 0 && secondIndex < matrix.GetLength(1))
                {
                    return matrix[firstIndex, secondIndex];
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid index value!");
                }
            }
            set 
            {
                if (firstIndex >= 0 && firstIndex < matrix.GetLength(0) &&
                    secondIndex >= 0 && secondIndex < matrix.GetLength(1))
                {
                    this.matrix[firstIndex, secondIndex] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid index value!");
                }
            }
        }

        // Methods
        public int GetCols()
        {
            return matrix.GetLength(0);
        }

        public int GetRows()
        {
            return matrix.GetLength(1);
        }

        public int Col { get; private set; }

        // Overload + operator
        public static Matrix<T> operator +(Matrix<T> firstMatrx, Matrix<T> secondMtrx)
        {
            Matrix<T> tempMatrix = new Matrix<T>(firstMatrx.GetRows(), firstMatrx.GetCols());

            if (firstMatrx.GetCols() == secondMtrx.GetCols() &&
                firstMatrx.GetRows() == secondMtrx.GetRows())
            {
                for (int row = 0; row < tempMatrix.GetRows(); row++)
                {
                    for (int col = 0; col < tempMatrix.GetCols(); col++)
                    {
                        tempMatrix[row, col] = (dynamic)firstMatrx[row, col] + (dynamic)secondMtrx[row, col];
                    }
                }

                return tempMatrix;
            }
            else
            {
                throw new ArgumentException("Matrixes must be of one size!");
            }
        }

        // overload - operator
        public static Matrix<T> operator -(Matrix<T> firstMatrx, Matrix<T> secondMtrx)
        {
            Matrix<T> tempMatrix = new Matrix<T>(firstMatrx.GetRows(), firstMatrx.GetCols());

            if (firstMatrx.GetCols() == secondMtrx.GetCols() &&
                firstMatrx.GetRows() == secondMtrx.GetRows())
            {
                for (int row = 0; row < tempMatrix.GetRows(); row++)
                {
                    for (int col = 0; col < tempMatrix.GetCols(); col++)
                    {
                        tempMatrix[row, col] = (dynamic)firstMatrx[row, col] - (dynamic)secondMtrx[row, col];
                    }
                }

                return tempMatrix;
            }
            else
            {
                throw new ArgumentException("Matrixes must be of one size!");
            }
        }

        // Overloading * operator
        public static Matrix<T> operator *(Matrix<T> firstMatrx, Matrix<T> secondMtrx)
        {
            Matrix<T> tempMatrix = new Matrix<T>(firstMatrx.GetRows(), firstMatrx.GetCols());

            if (firstMatrx.GetCols() == secondMtrx.GetRows())
            {
                for (int row = 0; row < tempMatrix.GetRows(); row++)
                {
                    for (int col = 0; col < tempMatrix.GetCols(); col++)
                    {
                        dynamic tempSum = 0;
                        for (int indexOfCol = 0; indexOfCol < tempMatrix.GetCols(); indexOfCol++)
                        {
                            tempSum = tempSum + (dynamic)firstMatrx[row, indexOfCol] * (dynamic)secondMtrx[indexOfCol, col];
                            tempMatrix[row, col] = tempSum;
                        }
                    }
                }

                return tempMatrix;
            }
            else
            {
                throw new ArgumentException("First matrix's cols must be equal to second matrix's rows!");
            }
        }

        // Overload true operator
        public static bool operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.GetRows(); row++)
            {
                for (int col = 0; col < matrix.GetCols(); col++)
                {
                    if (matrix[row, col] != (dynamic)0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.GetRows(); row++)
            {
                for (int col = 0; col < matrix.GetCols(); col++)
                {
                    if (matrix[row, col] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result.Append(matrix[i, j] + " ");
                }
                result.AppendLine();
            }

            return result.ToString().Trim();
        }
    }
}
