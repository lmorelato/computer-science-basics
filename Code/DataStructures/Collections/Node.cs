using System;

namespace Code.DataStructures.Collections
{
    public class Node<TData>
    {
        public TData Data;
        public Node<TData> Next;

        public Node()
        {
        }

        public Node(TData data, Node<TData> next = null)
        {
            Data = data;
            Next = next;
        }
    }
}
