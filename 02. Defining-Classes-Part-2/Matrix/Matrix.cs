using System;
using System.Text;

namespace DefiningClassesPart2.Matrix
{
    public class Matrix<T>
    {
        private int rows;
        private int cols;
        private T[,] data;

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            data = new T[rows, cols];
        }

        public int Rows
        {
            get
            {
                return rows;
            }
        }

        public int Cols
        {
            get
            {
                return cols;
            }
        }

        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= rows || col < 0 || col >= cols)
                {
                    throw new IndexOutOfRangeException($"Invalid cell: {row}, {col}");
                }

                return data[row, col];
            }

            set
            {
                if (row < 0 || row >= rows || col < 0 || col >= cols)
                {
                    throw new IndexOutOfRangeException($"Invalid cell: {row}, {col}");
                }

                data[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> left, Matrix<T> right)
        {
            // first make sure matrices can be added
            if (left.rows != right.rows || left.cols != right.cols)
            {
                throw new InvalidOperationException("Can't add matrices of different sizes.");
            }

            var rows = left.rows;
            var cols = left.cols;
            var result = new Matrix<T>(rows, cols);

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    result[i, j] = (dynamic)left[i, j] + right[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> left, Matrix<T> right)
        {
            // first make sure matrices can be subtracted
            if (left.rows != right.rows || left.cols != right.cols)
            {
                throw new InvalidOperationException("Can't add matrices of different sizes.");
            }

            var rows = left.rows;
            var cols = left.cols;
            var result = new Matrix<T>(rows, cols);

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    result[i, j] = (dynamic)left[i, j] - right[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> left, Matrix<T> right)
        {
            // first make sure matrices can be multiplied
            if (left.cols != right.rows)
            {
                throw new InvalidOperationException("Number of columns of first matrix does not match number of rows of second matrix.");
            }

            var rows = left.rows;
            var cols = right.cols;
            var result = new Matrix<T>(rows, cols);

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    result[i, j] = default(T);

                    for (var k = 0; k < left.cols; k++)
                    {
                        result[i, j] += (dynamic)left[i, k] * right[k, j];
                    }
                }
            }

            return result;
        }

        public static bool operator true(Matrix<T> m)
        {
            for (var i = 0; i < m.rows; i++)
            {
                for (var j = 0; j < m.cols; j++)
                {
                    // if there is a non-zero element
                    if ((dynamic)m[i, j] != default(T))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator false(Matrix<T> m)
        {
            for (var i = 0; i < m.rows; i++)
            {
                for (var j = 0; j < m.cols; j++)
                {
                    if ((dynamic)m[i, j] != default(T))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    sb.Append($"{this[i, j]} ");
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
