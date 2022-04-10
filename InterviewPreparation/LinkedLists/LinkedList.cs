namespace DataStructures.LinkedLists
{
    public class LinkedList<T>
    {
        public Node<T> Head;

        public LinkedList()
        {
            Head = null;
        }

        public LinkedList(Node<T> node)
        {
            Head = node;
        }

        public Node<T> RemoveElements(Node<T> head, T val)
        {
            return null;
        }

        public Node<T> Reverse(Node<T> head)
        {
            Node<T> prev = null;
            Node<T> curr = head;

            while (curr != null)
            {
                var temp = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = temp;
            }

            return prev;
        }

        public Node<T> EndOfFirstHalf(Node<T> head)
        {
            var fast = head;
            var slow = head;
            while (fast.Next != null && fast.Next.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
            }

            return slow;
        }
    }
}
