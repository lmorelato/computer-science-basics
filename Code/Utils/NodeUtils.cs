using System;
using Code.DataStructures.Collections;

namespace Code.Utils
{
    public static class NodeUtils<T>
    {
        public static void ThrowIfNull(SingleNode<T> node)
        {
            if (node == null) throw new NullReferenceException();
        }
    }
}
