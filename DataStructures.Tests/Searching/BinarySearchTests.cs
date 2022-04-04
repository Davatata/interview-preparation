using DataStructures.Searching;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Searching.Tests
{
    [TestClass()]
    public class BinarySearchTests
    {
        [TestMethod()]
        public void SearchTest_ShouldReturn_4()
        {
            var input = new int[] { -1, 0, 3, 5, 9, 12 };
            var target = 9;

            var expected = 4;

            var result = BinarySearch.Template1(input, target);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void SearchTest_ShouldReturn_Minus1()
        {
            var input = new int[] { -1, 0, 3, 5, 9, 12 };
            var target = 2;

            var expected = -1;

            var result = BinarySearch.Template1(input, target);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void MySqrt_ShouldReturn_2()
        {
            var input = 4;
            var expected = 2;

            var result = BinarySearch.MySqrt(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void MySqrt_ShouldReturn_46339()
        {
            var input = 2147395599;
            var expected = 46339;

            var result = BinarySearch.MySqrt(input);

            Assert.AreEqual(expected, result);
        }
    }
}