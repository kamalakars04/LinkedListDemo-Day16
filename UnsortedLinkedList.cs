using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDemo
{
    public class UnsortedLinkedList<T> : LinkedList<T> where T : IComparable
    {
        /// <summary>
        /// UC 1 and UC 3 Inserts at last.
        /// </summary>
        /// <param name="data">The data.</param>
        public void InsertAtLast(T data)
        {
            // If the linked list is empty
            if (this.head == null)
            {
                this.head = new Node<T>(data);
                return;
            }

            // If the head is already full
            Node<T> tempNode = GetLastNode();
            tempNode.next = new Node<T>(data);
        }

        /// <summary>
        /// Gets the last node.
        /// </summary>
        /// <returns></returns>
        private Node<T> GetLastNode()
        {
            Node<T> tempNode = this.head;
            while (tempNode.next != null)
                tempNode = tempNode.next;
            return tempNode;
        }

        /// <summary>
        /// UC 2 Inserts at first.
        /// </summary>
        /// <param name="data">The data.</param>
        public void InsertAtFirst(T data)
        {
            // If the linked list is empty
            if (this.head == null)
            {
                this.head = new Node<T>(data);
                Console.WriteLine(data + " Added successfully");
                return;
            }

            // If list is not empty then update the first term everytime
            Node<T> tempNode = this.head;
            this.head = new Node<T>(data);
            Console.WriteLine(data + " Added successfully");
            head.next = tempNode;
        }

        /// <summary>
        /// UC 4 Inserts in between.
        /// </summary>
        /// <param name="dataOne">The data one.</param>
        /// <param name="dataTwo">The data two.</param>
        /// <param name="data">The data.</param>
        public void InsertBetween(T dataOne, T dataTwo, T data)
        {
            // If the linked list is empty
            if (this.head == null || head.next == null)
            {
                Console.WriteLine("The specified order of elements not found");
                return;
            }

            // Search for the first element of user entry
            Node<T> tempNode = this.head;
            while (!(tempNode.data.Equals(dataOne) && tempNode.next.data.Equals(dataTwo)))
            {
                // Iterate to next node
                tempNode = tempNode.next;

                // If we have reached last elemnt
                if (tempNode.next == null)
                {
                    Console.WriteLine("The specified order of elements not found");
                    return;
                }
            }

            // If the elements entered by user are found
            // Store the node of second entry in temperory Node
            Node<T> tempNextNode = tempNode.next;

            // Fill the next of first node with new node 
            tempNode.next = new Node<T>(data);

            // Fill the next of new node with second entry node
            tempNode.next.next = tempNextNode;
        }

        /// <summary>
        /// UC 8 Inserts new element after the given element.
        /// </summary>
        /// <param name="afterData">The after data.</param>
        /// <param name="newData">The new data.</param>
        public void InsertAfterElement(T afterData, T newData)
        {
            // If linked list is empty
            if (this.head == null)
            {
                Console.WriteLine("\nNo elements in linked list");
                return;
            }

            // If head is not null
            Node<T> tempNode = this.head;
            while (!tempNode.data.Equals(afterData))
            {
                if (tempNode.next != null)
                    tempNode = tempNode.next;
                else
                {
                    Console.WriteLine("\nElement not found");
                    return;
                }
            }
            Node<T> newElement = new Node<T>(newData);

            // If element is to be inserted in between
            if (tempNode.next != null)
                InsertBetween(tempNode.data, tempNode.next.data, newData);

            // If the element needs to be inserted at last
            else
                InsertAtLast(newData);

            Console.WriteLine("\nElement inserted");
        }
    }
}
