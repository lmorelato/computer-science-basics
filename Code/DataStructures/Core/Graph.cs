namespace Code.DataStructures.Core
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
