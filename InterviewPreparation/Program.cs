using DataStructures.LinkedLists;
using System;
using System.Collections.Generic;

namespace InterviewPreparation
{
    class Program
    {

        static void Main(string[] args)
        {
            var node1 = new Node<int>(1);
            var node2 = new Node<int>(2);

            var list = new List<Node<int>>{ node1, node2 };

            for(var i = 3; i < 10; i++)
            {
                AddNode(i, list);
            }
            Console.WriteLine(list);
        }

        public static void AddNode(int x, List<Node<int>> list)
        {
            list.Add(new Node<int>(x));
        }
    }
}
