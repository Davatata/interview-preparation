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
            }
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

            CollectionAssert.AreEqual(numbers, sortedNumbers);
        }

        [TestMethod()]
        public void BubbleSort_50k_Ints()
        {
            Sorting.BubbleSort(numsCopy);
        }

        [TestMethod()]
        public void MergeSort_50k_Ints()
        {
            Sorting.MergeSort(numsCopy);
        }

        [TestMethod()]
        public void QuickSort_50k_Ints()
        {
            Sorting.QuickSort(numsCopy);
        }

        [TestMethod()]
        public void QuickSort_10_Ints()
        {
            Sorting.QuickSort(numbers);
            CollectionAssert.AreEqual(numbers, sortedNumbers);
        }
    }
}