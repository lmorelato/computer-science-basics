using System;
using System.Text;

namespace Code.DataStructures.Exercises
{
    public static class Matrices
    {
        /// <summary>
        /// time complexity = O(n^2)
        /// space complexity = O(n)
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static int[,] RotateSquareMatrixV1(int[,] matrix)
        {
            // validations
            var n = matrix.GetLength(0);
            if (n == 0) throw new ArgumentException("empty matrix!");

            var m = matrix.GetLength(1);
            if (n != m) throw new ArgumentException("must be a square matrix!");

            var result = new int[n, n];

            for (var i = 0; i < n; i++)
                for (var j = 0; j < n; j++)
                    result[j, n - 1 - i] = matrix[i, j];

            return result;
        }

        /// <summary>
        /// time complexity = O(n)
        /// space complexity = O(1)
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static void RotateSquareMatrixV2(int[,] matrix)
        {
            // validations
            var n = matrix.GetLength(0);
            if (n == 0) throw new ArgumentException("empty matrix!");

            var m = matrix.GetLength(1);
            if (n != m) throw new ArgumentException("must be a square matrix!");

            var length = n - 1;
            int temp;

            for (var i = 0; i < n / 2; i++)
            {
                for (var j = i; j < length - i; j++)
                {
                    temp = matrix[i, j];

                    // top-left <== bottom-left
                    matrix[i, j] = matrix[length - j, i];

                    // bottom-left <== bottom-right
                    matrix[length - j, i] = matrix[length - i, length - j];

                    // bottom-right <== top-right
                    matrix[length - i, length - j] = matrix[j, length - i];

                    // top-left <== top-left
                    matrix[j, length - i] = temp;
                }
            }
        }

        public static string Log(int[,] matrix)
        {
            var sb = new StringBuilder();
            var n = matrix.GetLength(0);
            var m = matrix.GetLength(1);

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++) sb.Append(matrix[i, j] + " ");
                sb.Append("\n");
            }
            return sb.ToString();
        }

        public static string Log(int[][] matrix)
        {
            var sb = new StringBuilder();

            foreach (var t in matrix)
            {
                foreach (var t1 in t) sb.Append(t1 + " ");
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}