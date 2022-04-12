using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        Left = new Node(value);
                    else
                        Left.Insert(value);
                }
                else
                {
                    if (Right == null)
                        Right = new Node(value);
                    else
                        Right.Insert(value);
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
        }
    }
}
