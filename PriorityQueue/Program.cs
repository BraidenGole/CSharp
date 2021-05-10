/**
 * File             :   Program.cs
 * Project          :   None
 * Programmer       :   Braiden Gole
 * First version    :   2021-05-10
 * Description      :   This is a priority queue implementation.
 */
using System;

namespace PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue.Node nodeClass = new Queue.Node();
            Queue.Node head = new Queue.Node();

            // Data, priority.
            head = nodeClass.Push(head, 5, 1);
            head = nodeClass.Push(head, 6, 2);
            head = nodeClass.Push(head, 7, 3);
            head = nodeClass.Push(head, 8, 0);

            nodeClass.DisplayQueue(head);
        }
    }
}
