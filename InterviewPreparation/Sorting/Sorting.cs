using System;

namespace DataStructures.Sorting
{
    public class Sorting
    {
        // O(n^2) average and worst time
        // O(1) memory
        public static void BubbleSort(int[] array)
        {
            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                for (var i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                        isSorted = false;
                    }
                }
            }
        }

        // O(n^2) average and worst case time
        // O(1) memory
        public static void SelectionSort(int[] array)
        {
            for (var i = 0; i < array.Length - 1; i++)
            {
                var minIndex = i;
                for (var j = i + 1; j< array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (i != minIndex)
                {
                    Swap(array, minIndex, i);
                }
            }
        }

        // O(n log n) average and worst time
        // O(n) space
        public static void MergeSort(int[] array) 
        {
            MergeSort(array, new int[array.Length],  0, array.Length - 1);
        }

        private static void MergeSort(int[] array, int[] temp, int leftStart, int rightEnd)
        {
            if (leftStart >= rightEnd)
            {
                return;
            }
            int middle = leftStart + (rightEnd - leftStart) / 2;
            MergeSort(array, temp, leftStart, middle);
            MergeSort(array, temp, middle + 1, rightEnd);
            MergeHalves(array, temp, leftStart, rightEnd);
        }

        private static void MergeHalves(int[] array, int[] temp, int leftStart, int rightEnd)
        {
            int leftEnd = leftStart + (rightEnd - leftStart) / 2;
            int rightStart = leftEnd + 1;
            int size = rightEnd - leftStart + 1;

            int left = leftStart;
            int right = rightStart;
            int index = leftStart;

            while (left <= leftEnd && right <= rightEnd)
            {
                if (array[left] <= array[right])
                {
                    temp[index] = array[left++];
                } else
                {
                    temp[index] = array[right++];
                }
                index++;
            }

            Array.Copy(array, left, temp, index, leftEnd - left + 1);
            Array.Copy(array, right, temp, index, rightEnd - right + 1);
            Array.Copy(temp, leftStart, array, leftStart, size);
        }

        public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        // O(n log n) average, O(n^2) worst
        // O(log n) memory
        private static void QuickSort(int[] array, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int pivot = array[left + (right - left) / 2];
            int index = Partition(array, left, right, pivot);
            QuickSort(array, left, index - 1);
            QuickSort(array, index, right);
        }

        private static int Partition(int[] array, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (array[left] < pivot)
                {
                    left++;
                }

                while (array[right] > pivot)
                {
                    right--;
                }

                if (left <= right) {
                    Swap(array, left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }


        private static void Swap(int[] array, int i, int j)
        {
            (array[j], array[i]) = (array[i], array[j]);
        }
    }
}
