using System;
using System.Collections.Generic;

namespace Code.DataStructures.Collections
{
    public class BTree<T>
    {
        #region properties
        public BTreeNode<T> Root;
        #endregion


        #region ctor
        public BTree() { }

        public BTree(T rooT)
        {
            Root = new BTreeNode<T>(rooT);
        }

        public BTree(BTreeNode<T> root)
        {
            Root = root;
        }
        #endregion


        #region print
        public string Print(BTreeTraversalMode mode = BTreeTraversalMode.InOrder)
        {
            if (Root == null) throw new NullReferenceException("no data");

            switch (mode)
            {
                case BTreeTraversalMode.InOrder:
                    return PrintInOrder(Root);
                case BTreeTraversalMode.PreOrder:
                    return PrintPreOrder(Root);
                case BTreeTraversalMode.PostOrder:
                    return PrintPostOrder(Root);
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
        }

        private string PrintInOrder(BTreeNode<T> node)
        {
            var str = string.Empty;

            // stop condition!
            if (node == null) return str;

            str += PrintInOrder(node.Left);
            str += "\n" + node;
            str += PrintInOrder(node.Right);
            return str;
        }

        private string PrintPreOrder(BTreeNode<T> node)
        {
            var str = string.Empty;

            // stop condition!
            if (node == null) return str;

            str += "\n" + node;
            str += PrintPreOrder(node.Left);
            str += PrintPreOrder(node.Right);
            return str;
        }

        private string PrintPostOrder(BTreeNode<T> node)
        {
            var str = string.Empty;

            // stop condition!
            if (node == null) return str;

            str += PrintPostOrder(node.Left);
            str += PrintPostOrder(node.Right);
            str += "\n" + node;
            return str;
        }
        #endregion


        #region insert

        public void Insert(T data, BTreeNode<T> tempRoot = null)
        {
            if (Root == null)
            {
                Root = new BTreeNode<T>(data);
                return;
            }

            if (tempRoot == null) tempRoot = Root;

            var newNode = new BTreeNode<T>(data);
            var queue = new Queue<BTreeNode<T>>();
            queue.Enqueue(tempRoot);

            // do level order traversal until we find an empty place
            while (queue.Count != 0)
            {
                tempRoot = queue.Peek();
                queue.Dequeue();

                if (tempRoot.Left == null)
                {
                    tempRoot.Left = newNode;
                    break;
                }
                queue.Enqueue(tempRoot.Left);

                if (tempRoot.Right == null)
                {
                    tempRoot.Right = newNode;
                    break;
                }
                queue.Enqueue(tempRoot.Right);
            }
        }

        #endregion
    }
}
