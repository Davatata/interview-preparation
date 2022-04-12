using DataStructures.BinaryTrees;
using DataStructures.LinkedLists;
using System;
using System.Collections.Generic;

namespace InterviewPreparation
{
    class Program
    {

        static void Main(string[] args)
        {
            // ============= BST ============

            var node10 = new BinaryTree.Node(10);
            node10.Insert(5);
            node10.Insert(8);
            node10.Insert(15);

            // Prints 5 8 10 15
            node10.PrintInOrder();

            // ============= BST ============
        }

    }
}
