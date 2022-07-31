using System;
using System.Collections.Generic;

namespace DataStructures.Trees
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
            return IsSymmetricHelper(root.Left, root.Right);
        }

        public bool IsSymmetricHelper(Node p, Node q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            if (p == null && q != null)
            {
                return false;
            }
            if (p != null && q == null)
            {
                return false;
            }
            if (p.Data != q.Data)
            {
                return false;
            }

            return IsSameTree(p.Left, q.Right) && IsSameTree(p.Right, q.Left);
        }

        public bool IsSameTree(Node p, Node q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            if (p == null && q != null)
            {
                return false;
            }
            if (p != null && q == null)
            {
                return false;
            }
            if (p.Data != q.Data)
            {
                return false;
            }

            return IsSameTree(p.Left, q.Left) && IsSameTree(p.Right, q.Right);
        }

        public static IList<int> RightSideView(Node root)
        {
            var result = new List<int>();

            if (root == null)
            {
                return result;
            }

            // 1. go level by level and add right-most node to result
            var queue = new Queue<Node>();
            queue.Enqueue(root);
            Node rightMost = null;

            while (queue.Count > 0)
            {
                var qCount = queue.Count;

                for (int i = 0; i < qCount; i++)
                {
                    var node = queue.Dequeue();
                    rightMost = node;
                    if (node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                    }
                    if (node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                    }
                }

                result.Add(rightMost.Data);
            }

            return result;
        }
    }
}
