using System.Transactions;

namespace Code.DataStructures.Collections
{
    public class DoubleNode<TData> : Node<TData>
    {
        public Node<TData> Prev;

        public DoubleNode()
        {
        }

        public DoubleNode(TData data, Node<TData> next = null, Node<TData> prev = null) : base(data, next)
        {
            Prev = prev;
        }
    }
}
