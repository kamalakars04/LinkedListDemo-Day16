// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kamalakar Rao Singaraju"/>
// --------------------------------------------------------------------------------------------------------------------
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
            UnsortedLinkedList<int> linkedList = new UnsortedLinkedList<int>();

            // UC 1 and UC 3 Adding elements to linkedlist
            linkedList.InsertAtLast(56);
            linkedList.InsertAtLast(30);
            linkedList.InsertAtLast(70);
            Console.WriteLine("\nAdded elements to last in linkedList");
            linkedList.DisplayLinkedList();


            // UC 2 Adding elements at first
            UnsortedLinkedList<int> linkedListOne = new UnsortedLinkedList<int>();
            linkedListOne.InsertAtFirst(70);
            linkedListOne.InsertAtFirst(30);
            linkedListOne.InsertAtFirst(56);
            Console.WriteLine("\nAdded elements to first in linkedlist one");
            linkedListOne.DisplayLinkedList();

            // UC 4 Adding elements in between two given values
            UnsortedLinkedList<int> linkedListTwo = new UnsortedLinkedList<int>();
            linkedListTwo.InsertAtLast(56);
            linkedListTwo.InsertAtLast(70);
            linkedListTwo.InsertBetween(56,70,30);
            Console.WriteLine("\nAdded elements in between in linked list two");
            linkedListTwo.DisplayLinkedList();

            // UC 5 Delete at beginning
            linkedListTwo.Pop();
            linkedListOne.PopLast();

            // UC 6 Displaying linked list
            linkedList.DisplayLinkedList();
            Console.Write("\n\nPopped last element");
            linkedListOne.DisplayLinkedList();
            Console.Write("\n\nPopped first element");
            linkedListTwo.DisplayLinkedList();

            // UC 7 Ability to search element
            linkedList.SearchElement(56);

            // UC 8 Ability to search element
            linkedList.InsertAfterElement(30, 40);
            linkedList.DisplayLinkedList();

            // UC 9 delete element and Implement size
            linkedList.PopElement(40);
            linkedList.DisplayLinkedList();

            // UC 10 ABility to create a sorted list
            SortedLinkedList<int> sortedLinkedList = new SortedLinkedList<int>();
            sortedLinkedList.InsertElement(56);
            sortedLinkedList.InsertElement(30);
            sortedLinkedList.InsertElement(40);
            sortedLinkedList.InsertElement(70);
            Console.WriteLine("\nElements of sorted list are : ");
            sortedLinkedList.DisplayLinkedList();
        }
    }
}
