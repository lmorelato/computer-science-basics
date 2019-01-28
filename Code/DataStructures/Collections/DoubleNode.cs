namespace Code.DataStructures.Collections
{
    public class DoubleNode<TData> : SingleNode<TData>
    {
        public DoubleNode<TData> Prev;

        public DoubleNode()
        {
        }

        public DoubleNode(TData data, SingleNode<TData> next = null, DoubleNode<TData> prev = null) : base(data, next)
        {
            Prev = prev;
        }

        public override string ToString()
        {
            return (Prev != null ? Prev.Data.ToString() : "NULL") + " <-> " +
                   "[" + (Data != null ? Data.ToString() : "NULL") + "]" + " <-> " +
                   (Next != null ? Next.Data.ToString() : "NULL");
        }
    }
}
