
using System.Collections;
using System.Collections.Generic;

namespace BinarySearcher
{
    public class Comparer : IComparer<int>
    {
        /// <summary>
        /// Method compares two elements
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>0, if elements are equal; 1, if x is greater then y, and -1, if  x is smaller then y </returns>
        public int Compare(int x, int y)
        {
            if (x == y)
            {
                return 0;
            }
            if (x > y)
            {
                return 1;
            }
            return -1;
        }
    }
    public static class BinarySearcher 
    {
        /// <summary>
        /// The method shows whether the array contains a specified number using Binary Searching 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns>true, if the array contains a value, and false, if is not</returns>
        public static bool BinarySearch(this int[] array, int value)
        {
            int bottom = 0;
            int top = array.Length - 1;
            int middle = top >> 1;
            while (top >= bottom)
            {
                if (array[middle] == value)
                {
                    return true;
                }
                if (array[middle] > value)
                {
                    top = middle - 1;
                }
                else
                {
                    bottom = middle + 1;
                }
                middle = (bottom + top) >> 1; //to avoid overflow
            }
            return false;
        }

        /// <summary>
        ///  The generic method shows whether the array contains a specified number using Binary Searching 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <param name="array"></param>
        /// <param name="comparer"></param>
        /// <returns>true, if the array contains a value, and false, if is not</returns>
        public static bool BinarySearch<T>(T item, T[] array, IComparer<T> comparer)
        {
            uint bottom = 0;
            uint top = (uint)array.Length - 1;
            uint middle = top >> 1;
            while (top >= bottom)
            {
                int compareResult = comparer.Compare(array[middle], item);

                if (compareResult == 0)
                {
                    return true;
                }
                if (compareResult > 0)
                {
                    top = middle - 1;
                }
                else
                {
                    bottom = middle + 1;
                }
                middle = (bottom + top) >> 1; // middle = bottom + ((top - bottom) / 2); ?
            }
            return false;
        }

        /// <summary>
        ///  The method shows whether the array contains a specified number using BinarySearch from ArrayList
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <param name="array"></param>
        /// <returns>true, if the array contains a value, and false, if is not</returns>
        public static bool BinarySearchThanksTooArrayList<T>(T item, T[] array)
        {
            ArrayList list = new ArrayList();
         
            for (int i = 0; i < array.Length; i++)
            {
                list.Add(array[i]);
            }
            list.Sort();
            int res = list.BinarySearch(item);
            if (res < 0)
            {
                return false;
            }
            return true;
        }
    }
}
