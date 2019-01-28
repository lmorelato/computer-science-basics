using System;

namespace Code.DataStructures.Collections
{
    public class BTreeNode<TData>
    {
        public TData Data;
        public BTreeNode<TData> Left;
        public BTreeNode<TData> Right;

        public BTreeNode()
        {
        }

        public BTreeNode(TData data, BTreeNode<TData> left = null, BTreeNode<TData> right = null)
        {
            Data = data;
            Left = left;
            Right = right;
        }

        public override string ToString()
        {
            return (Left != null ? Left.Data.ToString() : "NULL") + " <- " +
                   "[" + (Data != null ? Data.ToString() : "NULL") + "]" + " -> " +
                   (Right != null ? Right.Data.ToString() : "NULL");
        }
    }
}
