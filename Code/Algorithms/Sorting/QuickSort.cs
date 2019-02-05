using Code.Utils;

namespace Code.Algorithms.Sorting
{
    //https://www.geeksforgeeks.org/quick-sort/
    public static class QuickSort
    {
        public static void Perform(int[] arr)
        {
            QSort(arr, 0, arr.Length - 1);
        }

        /*
            The main function that implements QuickSort() 
            arr[] --> Array to be sorted, 
            low --> Starting index, 
            high --> Ending index 
        */
        private static void QSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                //pi is partitioning index, arr[pi] is now at right place
                int pi = Partition(arr, low, high);

                // Recursively sort elements before (left) partition
                QSort(arr, low, pi - 1);

                // Recursively sort elements after (right) partition 
                QSort(arr, pi + 1, high);
            }
        }

        /*
            This function takes last element as pivot, 
            places the pivot element at its correct 
            position in sorted array, and places all 
            smaller (smaller than pivot) to left of 
            pivot and all greater elements to right 
            of pivot 
         */
        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than or equal to pivot 
                if (arr[j] <= pivot)
                {
                    i++;
                    Swap(arr, i, j);
                    Logger.Debug(Logger.ToString(arr));
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            Swap(arr, i + 1, high);
            return i + 1;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
