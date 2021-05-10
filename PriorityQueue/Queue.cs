using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    public class Queue
    {
        public class Node
        {
            private Node Next { get; set; }
            private int Data { get; set; }
            private int Priority { get; set; }

            public Node ()
            {
                ; ;
            }

            public Node(int data, int priority)
            {
                this.Data = data;
                this.Priority = priority;
                this.Next = null;
            }

            /**     -- Method header comment
             *  Method          :   Push
             *  Description     :   This method will enqueue a number.
             *  Parameters      :   head, newData, priority
             *  Returns         :   head
             */
            public Node Push(Node head, int newData, int priority)
            {
                Node headReference = null;
                Node newNode = new Node(newData, priority);
                newNode.Next = null;

                headReference = head;

                if (head.Priority > priority)
                {
                    newNode.Next = head;
                    head = newNode;
                }
                else
                {
                    while (headReference.Next != null && headReference.Next.Priority < priority)
                    {
                        headReference = headReference.Next;
                    }

                    newNode.Next = headReference.Next;
                    headReference.Next = newNode;
                }
                return head;
            }

            /**     -- Method header comment
             *  Method          :   Pop
             *  Description     :   This method will delete an item from the queue.
             *  Parameters      :   head
             *  Returns         :   head
             */
            public Node Pop(Node head)
            {   
                if (head == null)
                {
                    return null;
                }
                
                Node delete = head;
                head = head.Next;
                return head;
            }

            /**     -- Method header comment
             *  Method          :   Peek
             *  Description     :   This method will return the peek of the queue.
             *  Parameters      :   head
             *  Returns         :   data
             */
            public int Peek(Node head)
            {
                if (head == null)
                {
                    return -1;
                }

                try
                {
                    int data = head.Data;
                    return data;
                }
                catch (NullReferenceException)
                {
                    return -1;
                }
            }

            /**     -- Method header comment
             *  Method          :   DisplayQueue
             *  Description     :   This method will show all of the elements in the Queue.
             *  Parameters      :   head
             *  Returns         :   None
             */
            public void DisplayQueue(Node head)
            {   
                if (head == null)
                {
                    return;
                }

                int peek = 0;
                while (head != null)
                {
                    head = Pop(head);
                    peek = Peek(head);

                    if (peek != -1)
                    {
                        Console.WriteLine(peek);
                    }
                }
            }
        }
    }
}
