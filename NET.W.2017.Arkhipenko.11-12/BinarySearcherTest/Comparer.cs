using System.Collections.Generic;

namespace BinarySearcherTest
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
}