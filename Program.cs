namespace LinkedListDemo
{
    using System;

    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List!");

            // Initialising a linked list
            LinkedList<int> linkedList = new LinkedList<int>();

            // UC 1 and UC 3 Adding elements to linkedlist
            linkedList.InsertAtLast(56);
            linkedList.InsertAtLast(30);
            linkedList.InsertAtLast(70);
            
            // UC 2 Adding elements at first
            LinkedList<int> linkedListOne = new LinkedList<int>();
            linkedListOne.InsertAtFirst(70);
            linkedListOne.InsertAtFirst(30);
            linkedListOne.InsertAtFirst(56);

            // UC 4 Adding elements in between two given values
            LinkedList<int> linkedListTwo = new LinkedList<int>();
            linkedListTwo.InsertAtLast(56);
            linkedListTwo.InsertAtLast(70);
            linkedListTwo.InsertBetween(56,70,30);

            // Displaying linked list
            linkedList.DisplayLinkedList();
            linkedListOne.DisplayLinkedList();
            linkedListTwo.DisplayLinkedList();
        }
    }
}
