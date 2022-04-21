using System;
using System.Collections.Generic;

namespace DataStructures.BinaryTrees
{
    public class BinaryTree
    {
        public class Node
        {
            public Node Left, Right;
            public int Data;

            public Node(int data)
            {
                Data = data;
            }

            public void Insert(int value)
            {
                if (value <= Data)
                {
                    if (Left == null)
                    {
                        Left = new Node(value);
                    }
                    else
                    {
                        Left.Insert(value);
                    }
                }
                else
                {
                    if (Right == null)
                    {
                        Right = new Node(value);
                    }
                    else
                    {
                        Right.Insert(value);
                    }
                }
            }

            public bool Contains(int value)
            {
                if (value == Data)
                {
                    return true;
                }
                else if (value < Data)
                {
                    if (Left == null)
                    {
                        return false;
                    }
                    else
                    {
                        return Left.Contains(value);
                    }
                }
                else
                {
                    if (Right == null)
                    {
                        return false;
                    }
                    else
                    {
                        return Right.Contains(value);
                    }
                }
            }

            public void PrintInOrder()
            {
                if (Left != null)
                {
                    Left.PrintInOrder();
                }
                Console.Write(Data + " ");
                if (Right != null)
                {
                    Right.PrintInOrder();
                }
            }

            public void PrintPreOrder(string spacing = "")
            {
                Console.WriteLine(spacing + Data);
                if (Left != null)
                {
                    Left.PrintPreOrder(spacing + " ");
                }
                if (Right != null)
                {
                    Right.PrintPreOrder(spacing + " ");
                }
            }

            public void PrintPostOrder()
            {
                if (Left != null)
                {
                    Left.PrintPostOrder();
                }
                if (Right != null)
                {
                    Right.PrintPostOrder();
                }
                Console.Write(Data + " ");
            }
        }

        private int TreeDepth { get; set; }

        public int MaximumDepth_TopDown(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            TreeDepth = 0;
            MaximumDepthTopDownHelper(node, TreeDepth + 1);
            return TreeDepth;
        }

        private void MaximumDepthTopDownHelper(Node node, int depth)
        {
            if (node == null) { return; }

            if (node.Left == null && node.Right == null)
            {
                TreeDepth = Math.Max(TreeDepth, depth);
            }

            MaximumDepthTopDownHelper(node.Left, depth + 1);
            MaximumDepthTopDownHelper(node.Right, depth + 1);
        }

        public int MaximumDepth_BottomUp(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            int left = MaximumDepth_BottomUp(node.Left);
            int right = MaximumDepth_BottomUp(node.Right);

            return Math.Max(left, right) + 1;
        }

        public bool IsSymmetric(Node root)
        {
            if (root == null) { return false; }

            var leftNodes = new List<int>();
            var rightNodes = new List<int>();

            // In order traversal of left and then right sub-trees.
            IsSymmetricHelper(root.Left, leftNodes);
            IsSymmetricHelper(root.Right, rightNodes);

            if (leftNodes.Count != rightNodes.Count) { return false; }

            for (int i = 0, j = leftNodes.Count - 1; i < leftNodes.Count && j >= 0; i++, j--)
            {
                if (leftNodes[i] != rightNodes[j])
                {
                    return false;
                }
            }

            return true;
        }

        private void IsSymmetricHelper(Node root, List<int> nodeList)
        {
            if (root == null) { return; }

            if (root.Left == null && root.Right != null)
            {
                nodeList.Add(101);
            } else
            {
                IsSymmetricHelper(root.Left, nodeList);
            }
                
            nodeList.Add(root.Data);
            
            if ( root.Right == null && root.Left != null)
            {
                nodeList.Add(101);
            } else
            {
                IsSymmetricHelper(root.Right, nodeList);
            }
        }

    }
}
