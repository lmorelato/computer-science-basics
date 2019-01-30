using System;
using System.Collections.Generic;

namespace Code.DataStructures.Collections
{
    public class Graph<T>
    {
        #region properties
        public GraphNode<T> Root;
        #endregion


        #region ctor
        public Graph() { }

        public Graph(T rooT)
        {
            Root = new GraphNode<T>(rooT);
        }

        public Graph(GraphNode<T> root)
        {
            Root = root;
        }
        #endregion


    }
}
