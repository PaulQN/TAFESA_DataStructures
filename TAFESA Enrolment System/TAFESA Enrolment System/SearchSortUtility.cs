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
        /// </summary>
        /// <typeparam name="T">The type of elements in the array, must implement IComparable&lt;T&gt;.</typeparam>
        /// <param name="array">The array to search through.</param>
        /// <param name="target">The item to search for.</param>
        /// <returns>The index of the target if found; otherwise, -1.</returns>
        public static int LinearSearchArray<T>(T[] array, T target) where T : IComparable<T>
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
        /// </summary>
        /// <typeparam name="T">The type of elements in the array, must implement IComparable&lt;T&gt;.</typeparam>
        /// <param name="array">The sorted array to search through.</param>
        /// <param name="target">The item to search for.</param>
        /// <returns>The index of the target if found; otherwise, -1.</returns>
        public static int BinarySearchArray<T>(T[] array, T target) where T : IComparable<T>
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
        /// <typeparam name="T">The type of elements in the array, must implement IComparable&lt;T&gt;.</typeparam>
        /// <param name="array">The array to be sorted in ascending order.</param>
        public static void SortAsc<T>(T[] array) where T : IComparable<T>
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
        /// <typeparam name="T">The type of elements in the array, must implement IComparable&lt;T&gt;.</typeparam>
        /// <param name="array">The array to be sorted in descending order.</param>
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
