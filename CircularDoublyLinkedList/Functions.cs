using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularDoublyLinkedList
{
    public class Functions
    {
        public class Node
        {
            public int Data { get; set; }
            public Node Prev { get; set; }
            public Node Next { get; set; }

            public Node(int data)
            {
                this.Data = data;
                this.Prev = null;
                this.Next = null;
            }
        }

        /**     -- Method header comment
         *  Method          :   Insert
         *  Description     :   This method is reponsible for inserting data
         *                      into the circular doubly linked list.
         *  Parameters      :   head, tail, data
         *  Returns         :   None
         */
        public void Insert(ref Node head, ref Node tail, int data)
        {
            Node newNode = new Node(data);
            
            if (head == null)
            {
                head = newNode;
                tail = newNode;

                newNode.Prev = tail;
                newNode.Next = head;
            }
            newNode.Next = head;
            head.Prev = newNode;
            newNode.Prev = tail;
            tail.Next = newNode;
            head = newNode;
        }

        /**     -- Method header comment
         *  Method          :   InsertAtHead
         *  Description     :   This method is responsible for inserting new data at
         *                      the head of the circular doubly linked list.
         *  Parameters      :   head, data
         *  Returns         :   None
         */
        public void InsertAtHead(ref Node head, int data)
        {
            Node newNode = new Node(data);
            Node lastEntry = head.Prev;

            newNode.Next = head;
            newNode.Prev = lastEntry;

            lastEntry.Next = newNode;
            head.Prev = newNode;
            head = newNode;
        }

        /**     -- Method header comment
         *  Method          :   Delete
         *  Description     :   This method is responsible for deleting a node in
         *                      the circular doubly linked list.
         *  Parameters      :   head, tail
         *  Returns         :   None
         */
        public void Delete(ref Node head, ref Node tail)
        {
            if (head != null)
            {
                if (head.Next == head)
                {
                    head = null;
                }
                else
                {
                    Node temp = head;
                    Node current = head;

                    while (temp.Next != head)
                    {
                        temp = temp.Next;
                    }
                    head = head.Next;
                    head.Prev = temp;
                    temp.Next = head;
                }
            }
        }

        /**     -- Method header comment
         *  Method          :   ShowCircularList
         *  Description     :   This method is responsible for showing the list in
         *                      a circular fashion to represent the structure.
         *  Parameters      :   head, tail
         *  Returns         :   None
         */
        public void ShowCircularList(Node head, Node tail)
        {   
            head = tail;
            do
            {
                Console.WriteLine(head.Data);
                head = head.Next;
            } while (head != tail);
        }

        /**     -- Method header comment
         *  Method          :   ShowReversedCircularList
         *  Description     :   This method is responsible for showing the circular
         *                      doubly linked list in reversed order.
         *  Parameters      :   tail, head
         *  Returns         :   None
         */
        public void ShowReversedCircularList(Node tail, Node head)
        {
            tail = head;
            do
            {
                Console.WriteLine(tail.Data);
                tail = tail.Prev;
            } while (tail != head);
        }
    }
}
