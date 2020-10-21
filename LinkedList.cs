namespace LinkedListDemo
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class LinkedList<T>
    {
        private Node<T> head;
        private Node<T> tempLastNode;

        /// <summary>
        /// UC 1 and UC 3 Inserts at last.
        /// </summary>
        /// <param name="data">The data.</param>
        public void InsertAtLast(T data) 
        {
            // If the linked list is empty
            if(this.head == null)
            {
                this.head = new Node<T>(data);
                tempLastNode = head;
                return;
            }

            // If the head is already full
            tempLastNode.next = new Node<T>(data);
            tempLastNode = tempLastNode.next;
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
                tempLastNode = head;
                Console.WriteLine(data+" Added successfully");
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
        public void InsertBetween(T dataOne,T dataTwo,T data)
        {
            // If the linked list is empty
            if (this.head == null)
            {
                Console.WriteLine("The specified order of elements not found");
                return;
            }

            // Search for the first element of user entry
            Node<T> tempNode = this.head;
            while(!(tempNode.data.Equals(dataOne) && tempNode.next.data.Equals(dataTwo) && tempNode.next != null))
            {
                tempNode = tempNode.next;
            }
            // If the elements entered by user are found
            if (tempNode.next == null)
                return;

            // If the elements entered by user are found
            // Store the node of second entry in temperory Node
            Node<T> tempNextNode = tempNode.next;

            // Fill the next of first node with new node 
            tempNode.next = new Node<T>(data);

            // Fill the next of new node with second entry node
            tempNode.next.next = tempNextNode;
        }

        /// <summary>
        /// Displays the linked list.
        /// </summary>
        public void DisplayLinkedList()
        {
            // If linked list is empty
            if(this.head == null)
            {
                Console.WriteLine("No elements in linked list");
                return;
            }

            // If linked list has elements then iterate till the next of a node is null
            Node<T> tempNode = this.head;
            Console.WriteLine("\nThe elements are : ");
            while(tempNode != null)
            {
                Console.Write(tempNode.data+"\t");
                tempNode = tempNode.next;
            }
        }
    }
}
