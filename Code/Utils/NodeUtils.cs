using System;

namespace Code.DataStructures.Collections
{
    public static class NodeUtils<TData>
    {
        public static void ThrowIfNull(Node<TData> node)
        {
            if (node == null) throw new NullReferenceException();
        }
    }
}
