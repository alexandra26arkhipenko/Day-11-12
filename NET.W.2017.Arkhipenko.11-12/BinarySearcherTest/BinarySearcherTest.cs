using System;
using BinarySearcher;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace BinarySearcherTest
{
    [TestClass]
    public class BinarySearcherTest
    {
        [TestMethod]
        public void BinarySearchTest()
        {
            int[] intArray = {1, 2, 5, 4, 3};
            char[] charArray = { 'a', 'b', 'c'};
            Assert.IsTrue(intArray.BinarySearch(2));
            Assert.IsTrue(BinarySearcher.BinarySearcher.BinarySearchThanksTooArrayList(5, intArray));
            Assert.IsTrue(BinarySearcher.BinarySearcher.BinarySearchThanksTooArrayList('a', charArray));
        }
    }
}
