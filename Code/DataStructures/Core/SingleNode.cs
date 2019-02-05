namespace Code.DataStructures.Core
{
    public class SingleNode<T>
    {
        public T Data;
        public SingleNode<T> Next;

        public SingleNode()
        {
        }

        public SingleNode(T data, SingleNode<T> next = null)
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
