using System;

namespace Code.DataStructures.Collections
{
    public class BTreeNode<TData>
    {
        #region properties
        public TData Data;
        public BTreeNode<TData> Left;
        public BTreeNode<TData> Right;
        #endregion

        #region ctor
        public BTreeNode()
        {
        }

        public BTreeNode(TData data, BTreeNode<TData> left = null, BTreeNode<TData> right = null)
        {
            Data = data;
            Left = left;
            Right = right;
        }
        #endregion

        #region print
        public override string ToString()
        {
            return (Data != null ? Data.ToString() : "null") + ": " +
                    (Left != null ? Left.Data.ToString() : "null") + "," +
                    (Right != null ? Right.Data.ToString() : "null");
        }

        #endregion
    }
}
