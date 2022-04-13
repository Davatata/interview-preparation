using DataStructures.BinaryTrees;
using System;

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

            // Prints
            // 5 8 10 15
            node10.PrintInOrder();
            Console.WriteLine();

            // Prints
            // 10
            //  5
            //   8
            //  15
            node10.PrintPreOrder();
            Console.WriteLine();

            // Prints
            // 8 5 15 10
            node10.PrintPostOrder();
            Console.WriteLine();

            // ============= BST ============
        }

    }
}
