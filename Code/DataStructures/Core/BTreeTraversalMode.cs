
namespace Code.DataStructures.Core
{
    public enum BTreeTraversalMode
    {
        InOrder, // left, node, right, i.e. visits in ascending order
        PreOrder, // node, left, right, i.e. visits root first
        PostOrder // left, right, node, i.e. visits root last
    }
}
