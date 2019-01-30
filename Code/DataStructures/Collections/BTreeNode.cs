using System;

namespace Code.DataStructures.Collections
{
    public class BTreeNode<T>
    {
        #region properties
        public T Data;
        public BTreeNode<T> Left;
        public BTreeNode<T> Right;
        #endregion

        #region ctor
        public BTreeNode()
        {
        }

        public BTreeNode(T data, BTreeNode<T> left = null, BTreeNode<T> right = null)
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
