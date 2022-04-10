namespace DataStructures.LinkedLists
{
    public class DoublyNode<T>
    {
        public T Val;
        public DoublyNode<T> Next;
        public DoublyNode<T> Prev;

        public DoublyNode(T val)
        {
            Val = val;
        }
    }
}
