using System;
using System.Collections.Generic;
using System.Text;
using Code.Utils;

namespace Code.Algorithms.Sorting
{
    public static class BubleSort
    {
        public static void PerformV1(int[] arr)
        {
            var n = arr.Length;

            for (var i = 0; i < n - 1; i++)
            {
                for (var j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j);
                    }
                    Logger.Debug(Logger.ToString(arr));

                }
                Logger.Debug("");
            }
        }

        public static void PerformV2(int[] arr)
        {
            var n = arr.Length;
            bool swapped;

            for (var i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (var j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j);
                        swapped = true;
                    }
                    Logger.Debug(Logger.ToString(arr));

                }

                // if no elements were swapped by inner loop, then break 
                if (!swapped) break;
                Logger.Debug("");
            }
        }

        private static void Swap(int[] arr, int j)
        {
            var temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
        }
    }
}
