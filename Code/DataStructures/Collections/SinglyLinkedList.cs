using System;
using System.Collections.Generic;
using System.Text;
using Code.DataStructures.Collections;

namespace Code.DataStructures
{
    public class SinglyLinkedList<TData>
    {
        public Node<TData> Head { get; private set; }
        public int Size { get; private set; }

        public SinglyLinkedList()
        {
        }

        public SinglyLinkedList(Node<TData> head)
        {
            Head = head;
        }

        public void Insert(TData data)
        {
            Size++;

            var newHead = new Node<TData>(data);
            if (Head != null)
                newHead.Next = Head;

            Head = newHead;
        }

        public void InsertAtEnd(TData data)
        {
            Size++;

            var newTail = new Node<TData>(data);
            newTail.Next = null;

            // empty list
            if (Head == null)
            {
                Head = newTail;
                return;
            }

            // let's find the tail
            var tail = Head;
            while (tail.Next != null)
                tail = tail.Next;

            tail.Next = newTail;
        }

        public void InsertAfter(TData searchData, TData newData)
        {
            Size++;

            var newNode = new Node<TData>(newData);
            newNode.Next = null;

            // empty list
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            // searching the node
            var searchNode = Head;
            while (searchNode?.Next != null)
            {
                if (EqualityComparer<TData>.Default.Equals(searchData, searchNode.Data))
                {
                    newNode.Next = searchNode.Next;
                    searchNode.Next = newNode;
                    return;
                }

                searchNode = searchNode.Next;
            }

            throw new ArgumentOutOfRangeException();
        }

        public void InsertBefore(TData data, Node<TData> refNode)
        {
            Size++;
        }

        public string Print()
        {
            var sb = new StringBuilder("");

            var node = Head;
            while (node != null)
            {
                sb.Append(node.Data == null ? "NULL" : node.Data.ToString());
                node = node.Next;

                if (node != null) sb.Append(" -> ");
            }
            return sb.ToString();
        }

        public string PrintR(Node<TData> node = null)
        {
            if (Head == null) return "";
            if (node == null) node = Head;

            // stop condition!
            if (node.Next == null)
                return node.Data.ToString();

            // keep going...
            var str = node.Data + " -> " + PrintR(node.Next);
            return str;
        }

        public string PrintReverseR(Node<TData> node = null)
        {
            if (Head == null) return "";
            if (node == null) node = Head;

            // stop condition!
            if (node.Next == null)
                return node.Data.ToString();

            // keep going...
            var str = PrintReverseR(node.Next) + " -> " + node.Data;
            return str;
        }
    }
}
