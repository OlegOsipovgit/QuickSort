using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort;

namespace UnitTestQuickSort
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] expected = new int[5] { 3, 4, 5, 6, 7 };
            int[] array = new int[5] { 5, 3, 6, 7, 4 };

            QuickSorting a = new QuickSorting();
            int[] actual = QuickSorting.Sorting(array,0,array.Length-1);
            Assert.AreEqual(expected,actual);
        }
    }
}
