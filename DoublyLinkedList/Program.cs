/**
 * File             :   Program.cs
 * Project          :   None
 * Programmer       :   Braiden Gole
 * First version    :   2021-05-22
 * Description      :   This is a doubly linked list implementation.
 */
using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions func = new Functions();
            Functions.Node head = null;
            Functions.Node tail = null;

            func.Push(ref head, 1);
            func.Append(ref head, ref tail, 2);
            func.InsertInBetween(head, 3);
            func.Push(ref head, 4);

            func.Delete(ref head, ref tail, 3);

            // Show the list with the added data.
            func.ShowList(head);

            //func.ShowReversedList(tail);
        }
    }
}
