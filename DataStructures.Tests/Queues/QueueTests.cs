using DataStructures.LinkedLists;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Queues.Tests
{
    [TestClass()]
    public class QueueTests
    {


        [TestMethod()]
        public void IsEmptyTest_ShouldReturnTrue()
        {
            var queue = new Queue();

            Assert.IsTrue(queue.IsEmpty());
        }

        [TestMethod()]
        public void IsEmptyTest_ShouldReturnFalse()
        {
            var queue = new Queue();
            var node = new Node<int>(1);
            queue.Head = node;
            queue.Tail = node;

            Assert.IsFalse(queue.IsEmpty());
        }

        [TestMethod()]
        public void PeekTest_ShouldReturn1()
        {
            var queue = new Queue();
            var node = new Node<int>(1);
            queue.Head = node;
            queue.Tail = node;

            Assert.AreEqual(1, queue.Peek());
        }

        [TestMethod()]
        public void AddTest_ShouldNotBeEmpty()
        {
            var queue = new Queue();
            queue.Add(1);

            Assert.IsFalse(queue.IsEmpty());
        }

        [TestMethod()]
        public void RemoveTest()
        {
            var queue = new Queue();
            var node = new Node<int>(1);
            queue.Head = node;
            queue.Tail = node;

            queue.Remove();

            Assert.IsTrue(queue.IsEmpty());
        }
    }
}