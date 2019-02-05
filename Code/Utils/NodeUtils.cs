using System;
using Code.DataStructures.Core;

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
