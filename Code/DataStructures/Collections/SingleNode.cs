using System;

namespace Code.DataStructures.Collections
{
    public class SingleNode<TData>
    {
        public TData Data;
        public SingleNode<TData> Next;

        public SingleNode()
        {
        }

        public SingleNode(TData data, SingleNode<TData> next = null)
        {
            Data = data;
            Next = next;
        }

        public override string ToString()
        {
            return "[" + (Data != null ? Data.ToString() : "NULL") + "]" + " -> " +
                   (Next != null ? Next.Data.ToString() : "NULL");
        }
    }
}
