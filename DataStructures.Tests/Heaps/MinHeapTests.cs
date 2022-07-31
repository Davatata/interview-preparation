using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Heaps.Tests
{
    [TestClass()]
    public class MinHeapTests
    {
        static MinHeap Heap;

        [TestInitialize]
        public void TestSetup()
        {
            Heap = new MinHeap();
        }

        [TestMethod()]
        public void PeekEmptyTest()
        {
            Assert.AreEqual(0, Heap.Peek());
        }

        [TestMethod()]
        [DataRow(new int[] { 10, 5, 1, 3 }, 1)]
        [DataRow(new int[] { 12, 9, 7, 8 }, 7)]
        [DataRow(new int[] { 50, 9, 8, 6 }, 6)]
        [DataRow(new int[] { 0, 1, 9, 2 }, 0)]
        public void PollReturnsTopTest(int[] nums, int expected)
        {
            //Act
            foreach (var num in nums)
            {
                Heap.Add(num);
            }

            //Test
            Assert.AreEqual(expected, Heap.Poll());
        }

        [TestMethod()]
        [DataRow(new int[] { 10, 5, 1, 3, 0 }, 4)]
        [DataRow(new int[] { 12, 9, 7, 3 }, 3)]
        [DataRow(new int[] { 50, 9, 1 }, 2)]
        [DataRow(new int[] { 2, -2 }, 1)]
        public void PollSizeAdjustsSizeTest(int[] nums, int expected)
        {
            //Act
            foreach (var num in nums)
            {
                Heap.Add(num);
            }
            _ = Heap.Poll();

            //Test
            Assert.AreEqual(expected, Heap.Size);
        }

        [TestMethod()]
        [DataRow(1, 1)]
        [DataRow(2, 2)]
        [DataRow(3, 3)]
        [DataRow(4, 4)]
        public void AddSingleTest(int a, int b)
        {
            //Act
            Heap.Add(a);

            //Test
            Assert.AreEqual(a, Heap.Peek());
        }

        [TestMethod()]
        [DataRow(new int[] { 10, 5, 1, 3 }, 1)]
        [DataRow(new int[] { 12, 9, 7, 8 }, 7)]
        [DataRow(new int[] { 50, 9, 8, 6 }, 6)]
        [DataRow(new int[] { 0, 1, 9, 2 }, 0)]
        public void HeapifyUpTest(int[] nums, int expected)
        {
            //Act
            foreach (var num in nums)
            {
                Heap.Add(num);
            }

            //Test
            Assert.AreEqual(expected, Heap.Peek());
        }

        [TestMethod()]
        [DataRow(new int[] { 10, 5, 1, 3, 0 }, 1)]
        [DataRow(new int[] { 12, 9, 7, 3 }, 7)]
        [DataRow(new int[] { 50, 9, 1 }, 9)]
        [DataRow(new int[] { 2, -2 }, 2)]
        public void HeapifyDownTest(int[] nums, int expected)
        {
            //Act
            foreach (var num in nums)
            {
                Heap.Add(num);
            }

            _ = Heap.Poll();

            //Test
            Assert.AreEqual(expected, Heap.Peek());
        }
    }
}