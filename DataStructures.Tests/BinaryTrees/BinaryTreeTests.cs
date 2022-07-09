using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DataStructures.BinaryTrees.BinaryTree;

namespace DataStructures.BinaryTrees.Tests
{
    [TestClass]
    public class BinaryTreeTests
    {
        BinaryTree Tree;
        Node Root;

        [TestInitialize]
        public void Setup()
        {
            // Runs before each test. (Optional)
            Tree = new BinaryTree();
            Root = new Node(5);

            Root.Insert(6);
            Root.Insert(7);
            Root.Insert(2);
            Root.Insert(1);
            Root.Insert(4);
            Root.Insert(3);

            /* Tree
                          5
                        /   \
                       2     6
                      / \     \
                     1   4     7
                        /
                       3
             */
        }

        [TestMethod]
        public void MaximumDepth_TopDownTest_ShouldBe4()
        {
            var answer = Tree.MaximumDepth_TopDown(Root);
            Assert.AreEqual(4, answer);
        }

        [TestMethod]
        public void MaximumDepth_BottomUpTest_ShouldBe4()
        {
            var answer = Tree.MaximumDepth_BottomUp(Root);
            Assert.AreEqual(4, answer);
        }

        [TestMethod]
        public void IsSymmetricTest_ShouldBeFalse()
        {
            var root = new Node(1);

            root.Left = new Node(2);
            root.Left.Left = new Node(2);
            root.Right = new Node(2);
            root.Right.Left = new Node(2);

            /* Tree
                          1
                        /   \
                       2     2
                      /     /
                     2     2                       
             */

            var answer = Tree.IsSymmetric(root);
            Assert.IsFalse(answer);
        }

        [TestMethod]
        public void IsSymmetricTest_ShouldBeTrue()
        {
            var root = new Node(1);
            root.Left = new Node(2);
            root.Left.Left = new Node(3);
            root.Right = new Node(2);
            root.Right.Right = new Node(3);

            /* Tree
                          1
                        /   \
                       2     2
                      /       \
                     3         3                       
             */

            var answer = Tree.IsSymmetric(root);
            Assert.IsTrue(answer);
        }

        [TestMethod]
        public void IsSymmetricTest_ShouldBeFalse2()
        {
            var root = new Node(5);
            root.Left = new Node(4);
            root.Left.Right = new Node(1);
            root.Left.Right.Left = new Node(2);
            root.Right = new Node(1);
            root.Right.Right = new Node(4);
            root.Right.Right.Left = new Node(2);

            /* Tree
                          5
                        /   \
                       4     1
                        \     \
                         1     4                       
                        /     /
                       2     2
             */

            root.PrintInOrder();

            var answer = Tree.IsSymmetric(root);
            Assert.IsFalse(answer);
        }
    }
}