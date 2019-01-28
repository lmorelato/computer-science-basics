using System;
using System.Collections.Generic;
using System.Text;

namespace Code.DataStructures.Collections
{
    public class BTree<TData>
    {
        public BTreeNode<TData> Root;

        public BTree(){}

        public BTree(TData rootData)
        {
            Root = new BTreeNode<TData>(rootData);
        }

        public BTree(BTreeNode<TData> root)
        {
            Root = root;
        }
    }
}
