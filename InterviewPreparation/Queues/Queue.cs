using DataStructures.LinkedLists;

namespace DataStructures.Queues
{
    public class Queue
    {
        public Node<int> Head;
        public Node<int> Tail;

        public bool IsEmpty()
        {
            return Head == null;
        }

        public int Peek()
        {
            return Head.Data;
        }

        public void Add(int data)
        {
            var node = new Node<int>(data);

            if(Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
        }

        public int Remove()
        {
            var data = Head.Data;
            Head = Head.Next;

            if (Head == null)
                Tail = null;

            return data;
        }
    }
}
