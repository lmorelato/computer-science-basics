using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Code.Arrays.Exercises
{
    public static class Matrix
    {
        /// <summary>
        /// time complexity = O(n^2)
        /// space complexity = O(n)
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static int[,] RotateNxN_v0(int[,] matrix)
        {
            // validations
            var n = matrix.GetLength(0);
            var m = matrix.GetLength(1);

            if (n == 0) throw new ArgumentException("empty matrix!");
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
        public static int[,] RotateNxN_v1(int[,] matrix)
        {
            // validations
            var n = matrix.GetLength(0);
            var m = matrix.GetLength(1);

            if (n == 0) throw new ArgumentException("empty matrix!");
            if (n != m) throw new ArgumentException("must be a square matrix!");

            var length = n - 1;
            int temp;

            for (var i = 0; i < n / 2; i++)
            {
                for (var j = i; j < length - i; j++)
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[length - j, i];
                    matrix[length - j, i] = matrix[length - i, length - j];
                    matrix[length - i, length - j] = matrix[j, length - i];
                    matrix[j, length - i] = temp;
                }
            }

            return matrix;
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