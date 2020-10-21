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
        /// UC 1 Inserts at last.
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
            Console.WriteLine("The elements are : ");
            while(tempNode != null)
            {
                Console.Write(tempNode.data+"\t");
                tempNode = tempNode.next;
            }
        }
    }
}
