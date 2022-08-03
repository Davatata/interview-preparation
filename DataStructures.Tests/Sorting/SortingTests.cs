using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sorting.Tests
{
    [TestClass()]
    public class SortingTests
    {
        static int[] nums = new int[50_000];
        int[] numsCopy = new int[50_000];
        static int[] numsCopySorted = new int[50_000];
        static int[] numbers;
        int[] sortedNumbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        [ClassInitialize]
        public static void TestFixtureSetup(TestContext context)
        {
            // Runs before each test. (Optional)
            nums = new int[50_000];
            var rand = new Random();
            for (var i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next();
                numsCopySorted[i] = nums[i];
            }

            Array.Sort(numsCopySorted);
        }

        [TestInitialize]
        public void TestSetup()
        {
            for (var i = 0; i < nums.Length; i++)
            {
                numsCopy[i] = nums[i];
                
            }

            numbers = new int[] { 7, 2, 1, 9, 4, 8, 3, 6, 5, 0 };            
        }

        [TestMethod()]
        public void BubbleSort_10Ints()
        {
            Sorting.BubbleSort(numbers);
            CollectionAssert.AreEqual(sortedNumbers, numbers);
        }

        [TestMethod()]
        public void BubbleSort_50k_Ints()
        {
            Sorting.BubbleSort(numsCopy);
            CollectionAssert.AreEqual(numsCopySorted, numsCopy);
        }

        [TestMethod()]
        public void MergeSort_10_Ints()
        {
            Sorting.MergeSort(numbers);
            CollectionAssert.AreEqual(sortedNumbers, numbers);
        }

        [TestMethod()]
        public void MergeSort_50k_Ints()
        {
            Sorting.MergeSort(numsCopy);
            CollectionAssert.AreEqual(numsCopySorted, numsCopy);
        }

        [TestMethod()]
        public void QuickSort_10_Ints()
        {
            Sorting.QuickSort(numbers);
            CollectionAssert.AreEqual(sortedNumbers, numbers);
        }

        [TestMethod()]
        public void QuickSort_50k_Ints()
        {
            Sorting.QuickSort(numsCopy);
            CollectionAssert.AreEqual(numsCopySorted, numsCopy);
        }


        [TestMethod()]
        public void SelectionSortTest_10_Ints()
        {
            Sorting.SelectionSort(numbers);
            CollectionAssert.AreEqual(sortedNumbers, numbers);
        }

        [TestMethod()]
        public void SelectionSortTest_50k_Ints()
        {
            Sorting.SelectionSort(numsCopy);
            CollectionAssert.AreEqual(numsCopySorted, numsCopy);
        }
    }
}