using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Heaps
{
    public class MinHeap
    {
        public int Capacity = 10;
        public int Size = 0;

        public int[] Items = new int[10];

        private int GetLeftChildIndex(int parentIndex) { return 2 * parentIndex + 1; }
        private int GetRightChildIndex(int parentIndex) { return 2 * parentIndex + 2; }
        private int GetParentIndex(int childIndex) { return (childIndex - 1) / 2; }

        private bool HasLeftChild(int index) { return GetLeftChildIndex(index) < Size; }
        private bool HasRightChild(int index) { return GetRightChildIndex(index) < Size; }
        private bool HasParent(int index) { return GetParentIndex(index) >= 0; }

        private int LeftChild(int index) { return Items[GetLeftChildIndex(index)]; }
        private int RightChild(int index) { return Items[GetRightChildIndex(index)]; }
        private int Parent(int index) { return Items[GetParentIndex(index)]; }

        private void Swap(int indexOne, int indexTwo)
        {
            var temp = Items[indexOne];
            Items[indexOne] = Items[indexTwo];
            Items[indexTwo] = temp;
        }

        private void EnsureCapacity()
        {
            if (Size == Capacity)
            {
                var newItems = new int[Capacity * 2];
                Items.CopyTo(newItems, 0);
                Items = newItems;
            }
        }

        public int Peek()
        {
            return Items[0];
        }

        public int Poll()
        {
            int item = Items[0];
            Items[0] = Items[Size - 1];
            Size--;
            HeapifyDown();
            return item;
        }

        public void Add(int item)
        {
            EnsureCapacity();
            Items[Size] = item;
            Size++;
            HeapifyUp();
        }

        public void HeapifyDown()
        {

        }

        public void HeapifyUp()
        {

        }
    }
}
