/**
 * File             :   Program.cs
 * Project          :   None
 * Programmer       :   Braiden Gole
 * First version    :   2021-05-23
 * Description      :   This is a circular doubly linked list implementation.
 */
using System;

namespace CircularDoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions func = new Functions();

            Functions.Node head = null;
            Functions.Node tail = null;

            // Number 1 is the root in this case !
            func.Insert(ref head, ref tail, 1);
            func.Insert(ref head, ref tail, 2);
            func.Insert(ref head, ref tail, 3);

            // You must have an existing node before inserting at head.
            func.InsertAtHead(ref head, 6);
            func.InsertAtHead(ref head, 5);
            func.InsertAtHead(ref head, 4);

            //func.Delete(ref head, ref tail);
            //func.Delete(ref head, ref tail);
            //func.Delete(ref head, ref tail);

            func.ShowCircularList(head, tail);
            Console.WriteLine();
            func.ShowReversedCircularList(head, tail);
        }
    }
}
