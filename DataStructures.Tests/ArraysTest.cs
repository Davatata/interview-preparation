using DataStructures.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tests
{
    [TestClass]
    public class ArraysTest
    {
        [TestMethod]
        public void SortedSquares_Test1()
        {
            var input = new int[] { -4, -1, 0, 3, 10 };
            var expected = new int[] { 0, 1, 9, 16, 100 };

            var result = ArrayMethods.SortedSquares(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SortedSquares_Test2()
        {
            var input = new int[] { -7, -3, 2, 3, 11 };
            var expected = new int[] { 4, 9, 9, 49, 121 };

            var result = ArrayMethods.SortedSquares(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SortedSquares_Test3()
        {
            var input = new int[] { -5, -3, -2, -1 };
            var expected = new int[] { 1, 4, 9, 25 };

            var result = ArrayMethods.SortedSquares(input);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
