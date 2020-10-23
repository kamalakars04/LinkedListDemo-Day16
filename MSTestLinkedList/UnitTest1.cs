using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListDemo;
namespace MSTestLinkedList
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// UC 7 Searches for element.
        /// </summary>
        [TestMethod]
        public void SearchForElement()
        {
            // Arrange
            LinkedList<int> linkedListOne = new LinkedList<int>();
            linkedListOne.InsertAtFirst(70);
            linkedListOne.InsertAtFirst(30);
            linkedListOne.InsertAtFirst(56);

            // Act
            int expected = linkedListOne.SearchElement(30);

            // Assert
            Assert.AreEqual(2, expected);
        }
    }
}
