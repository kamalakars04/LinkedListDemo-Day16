// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedList.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kamalakar Rao Singaraju"/>
// --------------------------------------------------------------------------------------------------------------------
namespace LinkedListDemo
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LinkedList<T>
    {
        private Node<T> head;

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
        public Node<T> GetLastNode()
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
            if (this.head == null || head.next == null)
            {
                Console.WriteLine("The specified order of elements not found");
                return;
            }

            // Search for the first element of user entry
            Node<T> tempNode = this.head;
            while(!(tempNode.data.Equals(dataOne) && tempNode.next.data.Equals(dataTwo)))
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
        /// UC 5 Pops the first element.
        /// </summary>
        public void Pop()
        {
            // If linked list is empty
            if (this.head == null)
            {
                Console.WriteLine("\nNo elements in linked list");
                return;
            }

            // If linked list is not empty
            this.head = head.next;
        }

        /// <summary>
        /// UC 6 Pops the last.
        /// </summary>
        public void PopLast()
        {
            // If linked list is empty
            if (this.head == null)
            {
                Console.WriteLine("\nNo elements in linked list");
                return;
            }

            // If it has only one element
            if (head.next == null)
            {
                head = null;
                return;
            }

            // If the linked list is not empty
            Node<T> tempNode = this.head;

            // if next element is not equal to null
            while (tempNode.next.next != null)
                tempNode = tempNode.next;

            // Make the next of last but one element as null
            tempNode.next = null;
        }

        /// <summary>
        /// UC 7 Searches the element.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public int SearchElement(T data)
        {
            // If linked list is empty
            if (this.head == null)
            {
                Console.WriteLine("\nNo elements in linked list");
                return 0;
            }

            int elementNum = 1;
            Node<T> tempNode = this.head;

            // If the data of temp node is not equal to zero
            while (!tempNode.data.Equals(data))
            {
                if (tempNode.next != null)
                {
                    elementNum++;
                    tempNode = tempNode.next;
                }
                else
                {
                    Console.WriteLine("Element not found");
                    return 0;
                }
            }

            // Check the element number and return it
            Console.WriteLine($"\nElement found at {elementNum}");
            return elementNum;
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
            while(!tempNode.data.Equals(afterData))
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

        public void PopElement(T data)
        {
            // If linked list is empty
            if (this.head == null)
            {
                Console.WriteLine("\nNo elements in linked list");
                return;
            }

            // If the searched element is first element
            if (head.data.Equals(data))
                this.head = head.next;

            // If the list has only one element
            else if (head.next == null)
            {
                Console.WriteLine("Element not found");
                return;
            }
            Node<T> tempNode = this.head;

            // If data in tempNode is not equal to user entry then go to next node
            while(!tempNode.next.data.Equals(data))
            {
                if (tempNode.next != null)
                    tempNode = tempNode.next;
                else
                {
                    Console.WriteLine("Element not found");
                    return;
                }
            }

            // If given element is last element
            if (tempNode.next.next == null)
                PopLast();

            // Delete the element in between list
            tempNode.next = tempNode.next.next;
        }

        /// <summary>
        /// UC 9 To get the size of linked list
        /// </summary>
        /// <returns>size</returns>
        public int ImplementSize()
        {
            int count = 1;

            // If linked list is empty
            if (this.head == null)
            {
                Console.WriteLine("\nNo elements in linked list");
                return 0;
            }
            Node<T> tempNode = this.head;
            while (tempNode.next != null)
            {
                count++;
                tempNode = tempNode.next;
            }
            Console.WriteLine("\n The number of elements in linked list are : {0}",count);
            return count;
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
