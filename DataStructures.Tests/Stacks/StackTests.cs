using DataStructures.LinkedLists;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Stacks.Tests
{
    [TestClass()]
    public class StackTests
    {
        [TestMethod()]
        public void IsEmptyTest_ShouldBeTrue()
        {
            var stack = new Stack();

            Assert.IsTrue(stack.IsEmpty());
        }

        [TestMethod()]
        public void IsEmptyTest_ShouldBeFalse()
        {
            var stack = new Stack();
            stack.Top = new Node<int>(1);

            Assert.IsFalse(stack.IsEmpty());
        }

        [TestMethod()]
        public void PeekTest_ShouldBe1()
        {
            var num = 1;
            var stack = new Stack();
            stack.Top = new Node<int>(num);

            Assert.AreEqual(num, stack.Peek());
        }

        [TestMethod()]
        public void PushTest_ShouldAdd1Node()
        {
            var stack = new Stack();
            stack.Push(1);

            Assert.IsFalse(stack.IsEmpty());
        }

        [TestMethod()]
        public void PopTest_ShouldRemove1Node()
        {
            var num = 1;
            var stack = new Stack();
            stack.Top = new Node<int>(num);

            var topNum = stack.Pop();

            Assert.AreEqual(num, topNum);
        }

        [TestMethod()]
        public void PopTest_ShouldBeEmpty()
        {
            var num = 1;
            var stack = new Stack();
            stack.Top = new Node<int>(num);

            stack.Pop();

            Assert.IsTrue(stack.IsEmpty());
        }
    }
}