using System.ComponentModel;
using Code.DataStructures.Collections;

namespace Code.DataStructures
{
    public class LinkedList<TData>
    {
        public Node<TData> Head { get; private set; }
        public int Size { get; private set; }

        LinkedList() { }

        LinkedList(Node<TData> head)
        {
            Head = head;
        }

        public void Insert(Node<TData> newNode)
        {
            Size++;
        }

        public void InsertAfter(Node<TData> newNode, Node<TData> refNode)
        {
            Size++;
        }

        public void InsertBefore(Node<TData> newNode, Node<TData> refNode)
        {
            Size++;
        }

        public void InsertAtEnd(Node<TData> newNode)
        {
            Size++;
        }
    }
}
