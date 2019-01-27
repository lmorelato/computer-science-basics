using Code.DataStructures;
using Code.Utils;
using Xunit;

namespace Test.DataStructures.Collections
{
    public class SinglyLinkedListTest
    {
        [Fact]
        public void Insert_WhenCalled_ReturnSizeOfTheList()
        {
            //Arrange

            //Act
            var list = new SinglyLinkedList<int>();
            list.Insert(2);
            list.Insert(1);
            
            var result = list.PrintR();
            Output.Debug(result);

            //Assert
            Assert.Equal(expected: "1 -> 2", actual: result);
        }

        [Fact]
        public void InsertAtEnd_WhenCalled_ReturnSizeOfTheList()
        {
            //Arrange

            //Act
            var list = new SinglyLinkedList<int>();
            list.InsertAtEnd(1);
            list.InsertAtEnd(2);

            var result = list.PrintR();
            Output.Debug(result);

            //Assert
            Assert.Equal(expected: "1 -> 2", actual: result);
        }

        [Theory]
        [InlineData(new[] { 10, 20, 30 }, new[] { 12, 11 }, "10 -> 11 -> 12 -> 20 -> 30")]
        public void InsertAfter_WhenCalled_ReturnPrintedList(int[] data, int[] extraData, string expectedResult)
        {
            //Arrange

            //Act
            var list = new SinglyLinkedList<int>();
            foreach (var i in data) list.InsertAtEnd(i);
            Output.Debug(list.PrintR());

            foreach (var i in extraData) list.InsertAfter(data[0], i);
            
            var result = list.PrintR();
            Output.Debug(result);

            //Assert
            Assert.Equal(expected: expectedResult, actual: result);
        }
    }
}
