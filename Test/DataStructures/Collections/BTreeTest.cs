using Code.DataStructures.Collections;
using Code.Utils;
using Xunit;

namespace Test.DataStructures.Collections
{
    public class BTreeTest
    {
        [Theory]
        [InlineData(BTreeTraversalMode.InOrder, "\n2: null,null\n1: 2,3\n3: null,null")]
        [InlineData(BTreeTraversalMode.PreOrder, "\n1: 2,3\n2: null,null\n3: null,null")]
        [InlineData(BTreeTraversalMode.PostOrder, "\n2: null,null\n3: null,null\n1: 2,3")]
        public void Print_WhenCalled_PrintByTraversalMode(BTreeTraversalMode mode, string expected)
        {
            //Arrange
            var tree = new BTree<int?>(1);
            tree.Root.Left = new BTreeNode<int?>(2);
            tree.Root.Right = new BTreeNode<int?>(3);
            Output.Debug(mode.ToString());

            //Act
            var result = tree.Print(mode);
            Output.Debug(result);

            //Assert
            Assert.Equal(expected: expected, actual: result);
        }

        //[Theory]
        //[InlineData(new[] { 1, 2, 3, 4, 5, 6 }, "\n1: 2,3\n2: 4,5\n3: 6,null")]
        //public void Insert_WhenCalled_PrintTreeInOrder(int[] nodes, string expected)
        //{
        //    var tree = new BTree<int?>();

        //}

    }
}
