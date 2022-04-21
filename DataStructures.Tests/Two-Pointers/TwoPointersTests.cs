using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Two_Pointers.Tests
{
    [TestClass()]
    public class TwoPointersTests
    {
        [TestMethod()]
        [DataRow("abcabcbb", 3)]
        [DataRow("au", 2)]
        [DataRow("dvdf", 3)]
        [DataRow("aab", 2)]
        public void LengthOfLongestSubstring(string str, int expected)
        {
            var result = TwoPointers.LengthOfLongestSubstring(str);

            Assert.AreEqual(expected, result);
        }
    }
}