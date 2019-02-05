using System.Collections.Generic;
using System.Text;

namespace Code.DataStructures.Exercises
{
    public static class Arrays
    {
        /// <summary>
        /// https://leetcode.com/problems/3sum/
        /// https://www.geeksforgeeks.org/find-triplets-array-whose-sum-equal-zero/
        /// time complexity = O(n^3)
        /// space complexity = O(n)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public static List<int[]> FindTripletsV1(int[] array, int sum = 0)
        {
            var result = new List<int[]>();

            for (var i = 0; i < array.Length - 2; i++)
            {
                for (var j = i + 1; j < array.Length - 1; j++)
                {
                    for (var k = j + 1; k < array.Length; k++)
                    {
                        if (array[i] + array[j] + array[k] == sum)
                            result.Add(new[] { array[i], array[j], array[k] });
                    }
                }
            }

            return result;
        }
    }
}
