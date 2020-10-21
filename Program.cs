using System;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List!");

            // Initialising a linked list
            LinkedList<int> linkedList = new LinkedList<int>();

            // UC 1 Adding elements to linkedlist
            linkedList.InsertAtLast(56);
            linkedList.InsertAtLast(30);
            linkedList.InsertAtLast(70);

            LinkedList<int> linkedListOne = new LinkedList<int>();
            //UC 2 Adding elements at first
            linkedListOne.InsertAtFirst(70);
            linkedListOne.InsertAtFirst(30);
            linkedListOne.InsertAtFirst(56);

            // Displaying linked list
            linkedListOne.DisplayLinkedList();
        }
    }
}
