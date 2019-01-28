using System;
using Code.DataStructures.Collections;

namespace Code.Utils
{
    public static class NodeUtils<TData>
    {
        public static void ThrowIfNull(SingleNode<TData> node)
        {
            if (node == null) throw new NullReferenceException();
        }
    }
}
