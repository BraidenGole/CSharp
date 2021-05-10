/**
 * File             :   Program.cs
 * Project          :   None
 * Programmer       :   Braiden Gole
 * First version    :   2021-05-10
 * Description      :   This is a singly linked list implementation.
 */
using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinked op = new SinglyLinked();
            SinglyLinked.Node head = null;

            head = op.InsertNode(head, 1);
            head = op.InsertNode(head, 2);
            head = op.InsertNode(head, 3);
            head = op.InsertNode(head, 4);
            head = op.InsertNode(head, 5);
            head = op.InsertNode(head, 6);
            head = op.InsertNode(head, 7);
            head = op.InsertNode(head, 8);
            head = op.InsertNode(head, 9);
            head = op.InsertNode(head, 10);

            // Insert 200 in-between 1 and 2.
            head = op.InsertInBetween(head.Next, 200);

            // Now 100 will be the first node.
            head = op.InsertAtHead(head.Next, 100);

            // Now 100 will be gone.
            head = op.DeleteFromHead(head);
            
            // Now 200, 3, and 4 will be gone and we are left with the number 5.
            head = op.DeleteRangeOfNodes(head, head.Next.Next);

            // From this point we have the numbers printed from [5-10].

            // Update the number 5 to 1000.
            op.UpdateNode(head, head, 1000);

            // Add a node at the end.
            head = op.InsertNode(head, 9999);

            // Show the list before the data is sorted.
            op.ShowList(head);
        }
    }
}
