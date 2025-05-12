
using System;

namespace TAFESA_Enrolment_System
{
    /// <summary>
    /// Utility class that provides generic searching and sorting methods.
    /// </summary>
    public static class SearchSortUtility
    {
        /// <summary>
        /// Searches for a target item in an array using linear (sequential) search.
        /// Returns the index of the target if found, -1 otherwise.
        /// </summary>
        public static int LinearSearchArray<T>(T[] array, T target) where T : IComparable<T> //goes through each element one by one, it’s good for small or unsorted arrays.
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].CompareTo(target) == 0)
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// Searches for a target item in a sorted array using binary search.
        /// Returns the index of the target if found, -1 otherwise.
        /// </summary>
        public static int BinarySearchArray<T>(T[] array, T target) where T : IComparable<T> //faster but it requires the array to be sorted first.
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int comparison = array[mid].CompareTo(target);

                if (comparison == 0)
                    return mid;
                else if (comparison < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }

        /// <summary>
        /// Sorts the array in ascending order using Bubble Sort.
        /// </summary>
        public static void SortAsc<T>(T[] array) where T : IComparable<T> //Bubble Sort: it’s simple to implement.
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Sorts the array in descending order using Bubble Sort.
        /// </summary>
        public static void SortDesc<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) < 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
