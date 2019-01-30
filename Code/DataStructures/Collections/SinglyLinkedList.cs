using System;
using System.Collections.Generic;
using System.Text;

namespace Code.DataStructures.Collections
{
    public class SinglyLinkedList<T>
    {
        #region properties

        public SingleNode<T> Head { get; private set; }
        public int Size { get; private set; } 

        #endregion


        #region ctor

        public SinglyLinkedList()
        {
        }

        public SinglyLinkedList(SingleNode<T> head)
        {
            Head = head;
        }
        #endregion
        

        #region insert
        public void Insert(T data)
        {
            Size++;

            var newHead = new SingleNode<T>(data);
            if (Head != null)
                newHead.Next = Head;

            Head = newHead;
        }


        public void InsertAtEnd(T data)
        {
            Size++;

            var newTail = new SingleNode<T>(data);
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

        public void InsertAfter(T searchData, T newData)
        {
            Size++;

            var newNode = new SingleNode<T>(newData);
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
                if (EqualityComparer<T>.Default.Equals(searchData, searchNode.Data))
                {
                    newNode.Next = searchNode.Next;
                    searchNode.Next = newNode;

                    return;
                }

                searchNode = searchNode.Next;
            }

            throw new ArgumentOutOfRangeException();
        }


        public void InsertBefore(T searchData, T newData)
        {
            Size++;

            var newNode = new SingleNode<T>(newData);
            newNode.Next = null;

            // empty list
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            // searching the curr
            var searchNode = Head;
            var previousNode = new SingleNode<T>();
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

        public string RecursivePrint(SingleNode<T> node = null)
        {
            if (Head == null) return "";
            if (node == null) node = Head;

            // stop condition!
            if (node.Next == null)
                return node.Data.ToString();

            // keep going...w
            var str = node.Data + " -> " + RecursivePrint(node.Next);
            return str;
        }


        public string RecursivePrintReverse(SingleNode<T> node = null)
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
        public SingleNode<T> RecursiveReverseOne(SingleNode<T> curr = null)
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
        public SingleNode<T> RecursiveReverseTwo(SingleNode<T> curr = null, SingleNode<T> previous = null)
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
