using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListDemo;
namespace MSTestLinkedList
{
    [TestClass]
    public class UnitTest1
    {
        UnsortedLinkedList<int> linkedListOne;
        [TestInitialize]
        public void setup()
        {
            linkedListOne = new UnsortedLinkedList<int>();
            linkedListOne.InsertAtFirst(70);
            linkedListOne.InsertAtFirst(30);
            linkedListOne.InsertAtFirst(56);
        }

        /// <summary>
        /// UC 7 Searches for element.
        /// </summary>
        [TestMethod]
        public void SearchForElement()
        {
            
            // Act
            int expected = linkedListOne.SearchElement(30);

            // Assert
            Assert.AreEqual(2, expected);
        }

        /// <summary>
        /// UC 8 Inserts after a specified element
        /// </summary>
        [TestMethod]
        public void InsertAfterElement()
        {
            // Arrange
            linkedListOne.InsertAfterElement(30, 40);

            // Act
            int actual = linkedListOne.SearchElement(40);
            int expected = linkedListOne.SearchElement(30);

            // Assert
            Assert.AreEqual(actual, expected+1);
        }

        /// <summary>
        /// UC 9 Gets the size.
        /// </summary>
        [TestMethod]
        public void GetSize()
        {
            // Arrange
            linkedListOne.InsertAfterElement(30, 40);

            // Act
            // Size of list before deletion
            int actual = linkedListOne.ImplementSize();

            // Delete an element
            linkedListOne.PopElement(40);

            // Size of the list after deletion
            int expected = linkedListOne.ImplementSize();

            // Assert
            Assert.AreEqual(actual, expected + 1);
        }
    }
}
