using DataStructures.Trees;
using System;
using System.Linq;

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

            var tree = new BinaryTree();
            Console.WriteLine("Top down Depth: " + tree.MaximumDepth_TopDown(node10));

            Console.WriteLine("Bottom up Depth: " + tree.MaximumDepth_BottomUp(node10));

            // ============= BST ============

            var str = "hello";
            var list = str.ToList();
            list.Sort();
            foreach (var ch in list)
            {
                Console.Write($"{ch} ");
            }
        }

    }
}
