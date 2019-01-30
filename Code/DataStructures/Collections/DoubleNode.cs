namespace Code.DataStructures.Collections
{
    public class DoubleNode<T> : SingleNode<T>
    {
        public DoubleNode<T> Prev;

        public DoubleNode()
        {
        }

        public DoubleNode(T data, SingleNode<T> next = null, DoubleNode<T> prev = null) : base(data, next)
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
