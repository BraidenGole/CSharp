/**
 * File             :   Program.cs
 * Project          :   None
 * Programmer       :   Braiden Gole
 * First version    :   2021-05-10
 * Description      :   This is a circular queue implementation.
 */
using System;

namespace CircularQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularQueue circQueue = new CircularQueue(10);
            int[] queueStorage = new int[circQueue.SizeOfQueue];

            circQueue.EnQueue(queueStorage, 1);
            circQueue.EnQueue(queueStorage, 2);
            circQueue.EnQueue(queueStorage, 3);
            circQueue.EnQueue(queueStorage, 4);
            circQueue.EnQueue(queueStorage, 5);
            circQueue.EnQueue(queueStorage, 6);
            circQueue.EnQueue(queueStorage, 7);
            circQueue.EnQueue(queueStorage, 8);
            circQueue.EnQueue(queueStorage, 9);

            circQueue.DeQueue(queueStorage);
            circQueue.DeQueue(queueStorage);

            Console.WriteLine("Peek: " + circQueue.Peek(queueStorage) + "\n");

            // Display the contents of the circular queue.
            circQueue.ShowQueue(queueStorage);
        }
    }
}
