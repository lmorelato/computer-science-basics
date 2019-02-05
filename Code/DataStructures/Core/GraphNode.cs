using System.Collections.Generic;

namespace Code.DataStructures.Core
{
    public class GraphNode<T>
    {
        #region properties
        public T Data;
        public List<GraphNode<T>> Children = new List<GraphNode<T>>();
        #endregion

        #region ctor
        public GraphNode()
        {
        }

        public GraphNode(T data)
        {
            Data = data;
        }
        #endregion

        #region print
        public override string ToString()
        {
            return Data != null ? Data.ToString() : "null";
        }

        #endregion
    }
}
