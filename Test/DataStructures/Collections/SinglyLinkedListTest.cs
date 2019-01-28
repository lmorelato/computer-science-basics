using Code.DataStructures.Collections;
using Code.Utils;
using Xunit;

namespace Test.DataStructures.Collections
{
    public class SinglyLinkedListTest
    {
        [Fact]
        public void ToString_WhenCalled_ReturnPrintedList()
        {
            //Arrange
            var list = new SinglyLinkedList<int?>();
            list.Insert(1);
            list.InsertAfter(1, 2);

            //Act
            var result = list.ToString();
            Output.Debug(result);

            //Assert
            Assert.Equal(expected: "1 -> 2", actual: result);
        }

        [Fact]
        public void RecursiveReverseOne_WhenCalled_ReversedList()
        {
            //Arrange
            var list = new SinglyLinkedList<int?>();
            list.Insert(3);
            list.Insert(2);
            list.Insert(1);
            Output.Debug(list.ToString());

            //Act
            list.RecursiveReverseOne();
            var result = list.ToString();
            Output.Debug(result);

            //Assert
            Assert.Equal(expected: "3 -> 2 -> 1", actual: result);
        }

        [Fact]
        public void RecursivePrint_WhenCalled_ReturnPrintedList()
        {
            //Arrange
            var list = new SinglyLinkedList<int?>();
            list.Insert(1);
            list.InsertAfter(1, 2);

            //Act
            var result = list.RecursivePrint();
            Output.Debug(result);

            //Assert
            Assert.Equal(expected: "1 -> 2", actual: result);
        }

        [Fact]
        public void RecursivePrintReverse_WhenCalled_ReturnPrintedList()
        {
            //Arrange
            var list = new SinglyLinkedList<int?>();
            list.Insert(1);
            list.InsertAfter(1, 2);

            //Act
            var result = list.RecursivePrintReverse();
            Output.Debug(result);

            //Assert
            Assert.Equal(expected: "2 -> 1", actual: result);
        }

        [Fact]
        public void Insert_WhenCalled_ReturnPrintedList()
        {
            //Arrange
            var list = new SinglyLinkedList<int?>();
            list.Insert(2);
            list.Insert(1);

            //Act
            var result = list.RecursivePrint();
            Output.Debug(result);

            //Assert
            Assert.Equal(expected: "1 -> 2", actual: result);
        }

        [Fact]
        public void InsertAtEnd_WhenCalled_ReturnPrintedList()
        {
            //Arrange
            var list = new SinglyLinkedList<int?>();
            list.InsertAtEnd(1);
            list.InsertAtEnd(2);

            //Act
            var result = list.RecursivePrint();
            Output.Debug(result);

            //Assert
            Assert.Equal(expected: "1 -> 2", actual: result);
        }

        [Theory]
        [InlineData(new[] { 10, 20, 30 }, new[] { 22, 21 }, 20, "10 -> 20 -> 21 -> 22 -> 30")]
        [InlineData(new[] { 10, 20, 30 }, new[] { 12, 11 }, 10, "10 -> 11 -> 12 -> 20 -> 30")]
        [InlineData(new[] { 10, 20, 30 }, new[] { 32, 31 }, 30, "10 -> 20 -> 30 -> 31 -> 32")]
        public void InsertAfter_WhenCalled_ReturnPrintedList(int[] data, int[] extraData, int insertAfter, string expectedResult)
        {
            //Arrange
            var list = new SinglyLinkedList<int?>();

            foreach (var i in data)
                list.InsertAtEnd(i);

            foreach (var i in extraData)
            {
                list.InsertAfter(insertAfter, i);
                Output.Debug(list.ToString());
            }

            //Act
            var result = list.RecursivePrint();
            Output.Debug(result);

            //Assert
            Assert.Equal(expected: expectedResult, actual: result);
        }

        [Theory]
        [InlineData(new[] { 10, 20, 30 }, new[] { 21, 22 }, 30, "10 -> 20 -> 21 -> 22 -> 30")]
        [InlineData(new[] { 10, 20, 30 }, new[] { 11, 12 }, 20, "10 -> 11 -> 12 -> 20 -> 30")]
        [InlineData(new[] { 10, 20, 30 }, new[] { 1, 2 }, 10, "1 -> 2 -> 10 -> 20 -> 30")]
        public void InsertBefore_WhenCalled_ReturnPrintedList(int[] data, int[] extraData, int insertBefore, string expectedResult)
        {
            //Arrange
            var list = new SinglyLinkedList<int?>();

            foreach (var i in data)
                list.InsertAtEnd(i);

            foreach (var i in extraData)
            {
                list.InsertBefore(insertBefore, i);
                Output.Debug(list.ToString());
            }

            //Act
            var result = list.RecursivePrint();
            Output.Debug(result);

            //Assert
            Assert.Equal(expected: expectedResult, actual: result);
        }
    }
}
