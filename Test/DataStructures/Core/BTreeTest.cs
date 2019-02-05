using Code.DataStructures.Core;
using Code.Utils;
using Xunit;

namespace Test.DataStructures.Core
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
            Logger.Debug(mode.ToString());

            //Act
            var result = tree.Print(mode);
            Logger.Debug(result);

            //Assert
            Assert.Equal(expected: expected, actual: result);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, "\n4: null,null\n2: 4,5\n5: null,null\n1: 2,3\n6: null,null\n3: 6,null")]
        public void Insert_WhenCalled_PrintTreeInOrder(int[] nodes, string expected)
        {
            //Arrange
            var tree = new BTree<int?>();

            //Act
            foreach (var node in nodes)
                tree.Insert(node);

            var result = tree.Print();
            Logger.Debug(result);

            //Assert
            Assert.Equal(expected: expected, actual: result);
        }

    }
}
