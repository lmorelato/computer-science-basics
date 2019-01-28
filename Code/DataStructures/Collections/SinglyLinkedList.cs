using System;
using System.Collections.Generic;
using System.Text;

namespace Code.DataStructures.Collections
{
    public class SinglyLinkedList<TData>
    {
        #region properties

        public SingleNode<TData> Head { get; private set; }
        public int Size { get; private set; } 

        #endregion


        #region ctor

        public SinglyLinkedList()
        {
        }

        public SinglyLinkedList(SingleNode<TData> head)
        {
            Head = head;
        }
        #endregion
        

        #region insert
        public void Insert(TData data)
        {
            Size++;

            var newHead = new SingleNode<TData>(data);
            if (Head != null)
                newHead.Next = Head;

            Head = newHead;
        }


        public void InsertAtEnd(TData data)
        {
            Size++;

            var newTail = new SingleNode<TData>(data);
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

            var newNode = new SingleNode<TData>(newData);
            newNode.Next = null;

            // empty list
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            // searching the curr
            var searchNode = Head;
            while (searchNode != null)
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


        public void InsertBefore(TData searchData, TData newData)
        {
            Size++;

            var newNode = new SingleNode<TData>(newData);
            newNode.Next = null;

            // empty list
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            // searching the curr
            var searchNode = Head;
            var previousNode = new SingleNode<TData>();
            while (searchNode != null)
            {
                if (searchData.Equals(searchNode.Data))
                {
                    // new curr is gonna be new head
                    if (previousNode.Next == null)
                        Head = newNode;
                    else
                        previousNode.Next = newNode;

                    newNode.Next = searchNode;
                    return;
                }

                previousNode = searchNode;
                searchNode = searchNode.Next;
            }

            throw new ArgumentOutOfRangeException();
        }
        #endregion


        #region print
        public override string ToString()
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

        public string RecursivePrint(SingleNode<TData> node = null)
        {
            if (Head == null) return "";
            if (node == null) node = Head;

            // stop condition!
            if (node.Next == null)
                return node.Data.ToString();

            // keep going...
            var str = node.Data + " -> " + RecursivePrint(node.Next);
            return str;
        }


        public string RecursivePrintReverse(SingleNode<TData> node = null)
        {
            if (Head == null) return "";
            if (node == null) node = Head;

            // stop condition!
            if (node.Next == null)
                return node.Data.ToString();

            // keep going...
            var str = RecursivePrintReverse(node.Next) + " -> " + node.Data;
            return str;
        }
        #endregion


        #region reverse
        /// <summary>
        /// A recursive function to reverse a linked list starting at tail
        /// </summary>
        /// <param name="curr">current curr</param>
        /// <returns>tail curr</returns>
        public SingleNode<TData> RecursiveReverseOne(SingleNode<TData> curr = null)
        {
            // list validation
            if (Head == null) return null;
            if (curr == null) curr = Head;

            // stop condition!
            if (curr.Next == null)
            {
                Head = curr;
                return curr;
            }

            // keep going...
            var nextNode = RecursiveReverseOne(curr.Next);
            nextNode.Next = curr;

            curr.Next = null;
            return curr;
        }


        /// <summary>
        /// A simple and tail recursive function to reverse a linked list, prev is passed as NULL initially. 
        /// </summary>
        /// <param name="curr">current curr</param>
        /// <param name="previous">previous curr</param>
        /// <returns>head curr</returns>
        public SingleNode<TData> RecursiveReverseTwo(SingleNode<TData> curr = null, SingleNode<TData> previous = null)
        {
            // list validation
            if (Head == null) return null;
            if (curr == null) curr = Head;

            // stop condition!
            if (curr.Next == null)
            {
                return null;
            }

            // keep going...

            return null;
        } 
        #endregion
    }
}
