using DataStructures.LinkedLists;

namespace DataStructures.Stacks
{
    public class Stack
    {
        public Node<int> Top;

        public bool IsEmpty()
        {
            return Top == null;
        }

        public int Peek()
        {
            return Top.Data;
        }

        public void Push(int data)
        {
            var node = new Node<int>(data);

            node.Next = Top;
            Top = node;
        }

        public int Pop()
        {
            var data = Top.Data;
            Top = Top.Next;
            return data;
        }
    }
}
