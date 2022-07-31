using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataStructures.Trees.BinaryTree;

namespace DataStructures.Trees.Tests
{
    [TestClass()]
    public class BinaryTreeTests
    {
        public Node List1 { get; set; }
        public Node List2 { get; set; }
        public Node List3 { get; set; }
        public Node List4 { get; set; }

        [TestInitialize]
        public void InitializeTest()
        {
            /* Tree
                  1
                /   \
               2     3
                \     \
                 5     4                     
            */
            List1 = new Node(1);
            List1.Left = new Node(2);
            List1.Right = new Node(3);
            List1.Left.Left = null;
            List1.Left.Right = new Node(5);
            List1.Right.Left = null;
            List1.Right.Right = new Node(4);

            /* Tree
                  1
                /   \
               2     3
                \     \
                 5     4
                /
               0
            */
            List2 = new Node(1);
            List2.Left = new Node(2);
            List2.Right = new Node(3);
            List2.Left.Left = null;
            List2.Left.Right = new Node(5);
            List2.Right.Left = null;
            List2.Right.Right = new Node(4);
            List2.Left.Right.Left = new Node(0);

            /* Tree
                  1
                   \
                    3
            */
            List3 = new Node(1);
            List3.Right = new Node(3);

            /* Tree
                  1
                    \
                     2
                      \
                       5
                      / \
                     4   6
                    /
                   3
            */
            List4 = new Node(1);
            List4.Right = new Node(2);
            List4.Right.Right = new Node(5);
            List4.Right.Right.Left = new Node(4);
            List4.Right.Right.Right = new Node(6);
            List4.Right.Right.Left.Left = new Node(3);

        }

        [TestMethod()]
        public void ReorderListTest_List1()
        {
            var result = (List<int>)BinaryTree.RightSideView(List1);

            var expected = new List<int>() { 1, 3, 4 };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ReorderListTest_List2()
        {
            var result = (List<int>)BinaryTree.RightSideView(List2);

            var expected = new List<int>() { 1, 3, 4, 0 };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ReorderListTest_List3()
        {
            var result = (List<int>)BinaryTree.RightSideView(List3);

            var expected = new List<int>() { 1, 3 };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ReorderListTest_List4()
        {
            var result = (List<int>)BinaryTree.RightSideView(List4);

            var expected = new List<int>() { 1,2,5,6,3 };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}